hurtbox_blacklist = {
  "airdodge",
  "crouch",
  "dashstart",
  "dashstop",
  "dashturn",
  "dash",
  "doublejump",
  "jumpstart",
  "jump",
  "landinglag",
  "land",
  "parry",
  "plat",
  "pratfall",
  "roll_backward",
  "roll_forward",
  "taunt",
  "tech",
  "walkturn",
  "walk",
  "walljump",
  "waveland"
}

function in_table(tbl, item)
  for _, v in ipairs(tbl) do
    if v == item then return true end
  end
  return false
end

function has_hurtbox_layer(sprite)
  for _, layer in ipairs(sprite.layers) do
    if layer.isGroup and layer.name == "hurtbox" then
      return true
    end
  end
  return false
end

OUTPATH = app.params["sprite_out_path"]

sprite_count = tonumber(app.params["sprite_count"])
for i=1, sprite_count do
  local file = app.params["sprite_" .. tostring(i)]
  app.open(file)
  -- app.command.OpenFile {
  --   filename = file,
  --   listLayers=false,
  --   listTags=false,
  --   listSlices=false
  -- }
end

for i,sprite in ipairs(app.sprites) do
  app.activeSprite = sprite
  app.command.SpriteSize {
    ui=false,
    scale=2.0,
    method="nearest"
  }

  local stripOutName =
    OUTPATH .. '/' ..
    app.fs.fileTitle(sprite.filename) ..
    "_strip" ..
    #sprite.frames ..
    ".png"

  app.command.ExportSpriteSheet {
    ui=false,
    askOverwrite=false,
    type=SpriteSheetType.HORIZONTAL,
    textureFilename=stripOutName,
    dataFilename="/",
    listLayers=false,
    listTags=false,
    listSlices=false
  }

  print("Strip saved:\n" .. stripOutName)

  if (tonumber(app.params["sprite_genhurt_" .. tostring(i)]) == 1)
     and (not in_table(hurtbox_blacklist, app.fs.fileTitle(sprite.filename))
     and has_hurtbox_layer(sprite))
  then
    for i, layer in ipairs(sprite.layers) do
      if not (layer.isGroup and layer.name == "hurtbox") then
        sprite:deleteLayer(layer)
      end
    end
    app.command.FlattenLayers()
    for i=1, #sprite.frames do
      app.activeFrame = i
      app.command.ReplaceColor {
        ui=false,
        channels=FilterChannels.RGB,
        from=Color {r=255, g=255, b=255, a=255},
        to=Color {r=0, g=255, b=0, a=255},
        tolerance=255
      }
    end
    local hurtboxStripOutName =
      OUTPATH .. '/' ..
      app.fs.fileTitle(sprite.filename) ..
      "_hurt_strip" ..
      #sprite.frames ..
      ".png"
    app.command.ExportSpriteSheet {
      ui=false,
      askOverwrite=false,
      type=SpriteSheetType.HORIZONTAL,
      textureFilename=hurtboxStripOutName,
      dataFilename="/",
      listLayers=false,
      listTags=false,
      listSlices=false
    }

    print("Hurtbox strip saved:\n" .. hurtboxStripOutName)
  end
end

