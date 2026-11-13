# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 200 files · ~694,867 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6510 nodes · 15565 edges · 232 communities (145 shown, 87 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 729 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `bba48993`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- three.core.js
- three.module.js
- .push
- app.js
- .copy
- Object3D
- Vector3
- BatchedMesh
- .Sweep
- ui.js
- .Export
- View3D
- Structures
- OrbitControls
- BufferAttribute
- List
- StructureMap
- WebGLRenderer
- Markers
- markers.js
- Dictionary
- .start
- WebGLState
- Stats
- update
- textures-hd.py
- WorldObjects
- get
- View3D
- measure.js
- system
- Features
- ForgeCanvas
- Audio
- Material
- Gear
- activity.js
- Sphere
- .constructor
- Vector2
- playercard.js
- ZDOID
- JsonWriter
- Vegetation
- leaflet.js
- Matrix4
- .distanceTo
- system_collections_generic
- AuthTests
- Mesh
- .equals
- .render
- Vector4
- Veg
- FogLayer
- PropertyBinding
- GateTests
- .parseObject
- Color
- Quaternion
- Box3
- xunit
- TileStore
- markercanvas.js
- Euler
- push
- GLTFLoader.js
- InlineData
- Discord
- AnimationAction
- TileJob
- Curve
- PMREMGenerator
- Fact
- Texture
- web/js/sky.js
- RigBuilder
- .constructor
- KeyframeTrack
- Items
- MapDataServer
- .assignTexture
- Func
- LoadingManager
- JsonElement
- AnimationMixer
- Loader
- WebGLProgram
- HashSet
- SerializedFile
- GLTFParser
- FeaturesTests
- MigrationTests
- RuinsGL
- RaidLayer
- WebMap
- web/js/view3d.js
- Matrix3
- WebGLBindingStates
- BundleFile
- package.json
- AudioListener
- Path
- BiomeMap
- Heights
- Using the map
- ChunkShapes
- PropertyMixer
- .load
- toLatLng
- MeshDecoder
- Hand
- GroundGL
- ObjectLoader
- Changelog
- WebMap.cs
- TerrainPatches
- arraysEqual
- .LookJson
- map-core.test.mjs
- Locations
- TileMath
- BuildingsGL
- ShapesCanvas
- particles.js
- WithDir
- ContourGL
- .load
- AnimationClip
- CubicBezierCurve
- Ping
- TilesTests
- Material
- .build
- k
- BufferGeometryUtils.js
- LightShadow
- QuadraticBezierCurve
- Png
- Français
- i18n.js
- PerspectiveCamera
- Interpolant
- PolyhedronGeometry
- InterleavedBuffer
- ChatRelay
- Camera
- RenderTarget
- RuinsLayer
- TreesGL
- check.mjs
- EventDispatcher
- parseUniform
- bench.mjs
- TextureDecoder
- .canopyMaterial
- MistGL
- FallbackTileLayer
- SmoothZoom
- vegpack.js
- .parse
- CurvePath
- Timer
- Layers
- VideoTexture
- WebGLShaderCache
- WebP
- AltBiomeGL
- BiomeGL
- GuideGL
- addShape
- Trails
- Shape
- SpotLight
- Announce
- m
- EllipseCurve
- CompressedTexture
- Spherical
- WebMap.Tests.csproj
- WebMap.csproj
- Window
- render
- fetchTerrarium
- FogGL
- .parse
- Cylindrical
- GLBufferAttribute
- .parse
- flatten
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- WebSocketHandler
- WebMapConfig
- be
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- CylinderGeometry
- DataArrayTexture
- bi
- Third-party notices
- GLTFMaterialsDispersionExtension
- .load
- InstancedBufferGeometry
- TextureUtils
- Setup
- testserver.sh
- StaticFilesTests
- MultiDrawRenderList
- Uniform
- layers.js
- CatmullRom
- CubicPoly
- getKeyframeOrder
- Int16BufferAttribute
- Int32BufferAttribute
- Int8BufferAttribute
- probeAsync
- Uint16BufferAttribute
- Uint32BufferAttribute
- Uint8BufferAttribute
- Uint8ClampedBufferAttribute

## God Nodes (most connected - your core abstractions)
1. `Vector3` - 114 edges
2. `Vector2` - 89 edges
3. `get()` - 88 edges
4. `MapDataServer` - 75 edges
5. `View3D` - 75 edges
6. `Markers` - 73 edges
7. `Object3D` - 70 edges
8. `BufferGeometry` - 69 edges
9. `Vector4` - 66 edges
10. `View3D` - 61 edges

## Surprising Connections (you probably didn't know these)
- `2.15.0` --references--> `look()`  [INFERRED]
  CHANGELOG.md → WebMap.Tests/web/rig.test.mjs
- `What a regression would do on the live server, worst first` --references--> `Auth`  [INFERRED]
  TESTING.md → WebMap/Auth.cs
- `What a regression would do on the live server, worst first` --references--> `Chart`  [INFERRED]
  TESTING.md → WebMap/Chart.cs
- `What a regression would do on the live server, worst first` --references--> `Features`  [INFERRED]
  TESTING.md → WebMap/Features.cs
- `What a regression would do on the live server, worst first` --references--> `ForestMap`  [INFERRED]
  TESTING.md → WebMap/ForestMap.cs

## Import Cycles
- None detected.

## Communities (232 total, 87 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (217): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+209 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (34): ColorManagement, InterpolationSamplingMode, InterpolationSamplingType, MOUSE, TimestampQuery, UniformsUtils, arrayCacheF32, arrayCacheI32 (+26 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (44): addContour(), AxesHelper, Box3Helper, buildPlane(), BoxHelper, BufferGeometry, getArrayBuffer(), getInterleavedBuffer() (+36 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (84): chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM, TILE (+76 more)

### Community 4 - ".copy"
Cohesion: 0.04
Nodes (17): a(), c(), handleTriangle(), handleVertex(), checkGeometryIntersection(), checkIntersection$1(), cloneUniformsGroups(), scalePt2() (+9 more)

### Community 5 - "Object3D"
Cohesion: 0.04
Nodes (7): CubeCamera, DirectionalLightHelper, FrustumArray, Object3D, SpotLightHelper, Sprite, StereoCamera

### Community 6 - "Vector3"
Cohesion: 0.03
Nodes (13): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+5 more)

### Community 7 - "BatchedMesh"
Cohesion: 0.04
Nodes (11): ascIdSort(), BatchedMesh, Bone, CatmullRomCurve3, copyArrayContents(), flattenJSON(), InstancedBufferAttribute, InstancedMesh (+3 more)

### Community 8 - ".Sweep"
Cohesion: 0.04
Nodes (24): Entry, Graves, Demisters, Dungeons, Signature, Inside, Visited, Kind (+16 more)

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (55): OBJECT_CATS, iconSvg(), escape(), makeIcon(), statsHtml(), BIOME_SVG, breakable(), BUILD_SVG (+47 more)

### Community 10 - ".Export"
Cohesion: 0.07
Nodes (11): GlbWriter, Count, Node, Primitive, Skin, PrefabExporter, Result, Joints (+3 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (13): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+5 more)

### Community 12 - "Structures"
Cohesion: 0.05
Nodes (23): ChunkCache, Line, Regions, Chunk, Ruins, IndexJson, LastChanged, Total (+15 more)

### Community 13 - "OrbitControls"
Cohesion: 0.05
Nodes (19): PlayerCard, MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel() (+11 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.05
Nodes (8): BufferAttribute, convertBufferAttribute(), copyAttributeData(), DataUtils, denormalize(), Float16BufferAttribute, InterleavedBufferAttribute, sortedArray()

### Community 15 - "List"
Cohesion: 0.06
Nodes (23): Kind, Kitchen, Made, Brewed, Burnt, Cooked, Honey, Smelted (+15 more)

### Community 16 - "StructureMap"
Cohesion: 0.05
Nodes (19): 2.10.0, Chart, Cell, ForestMap, LastStumps, LastTrees, Kind, Other (+11 more)

### Community 17 - "WebGLRenderer"
Cohesion: 0.06
Nodes (22): WebGLCubeRenderTarget, WebGLRenderTarget, _createRenderTarget(), getMaxPrecision(), getChannel(), getParameters(), WebGLRenderer, renderObject() (+14 more)

### Community 18 - "Markers"
Cohesion: 0.07
Nodes (10): BaseOverride, BedSpot, Markers, Json, Rev, PartTimer, Portal, SignSpot (+2 more)

### Community 19 - "markers.js"
Cohesion: 0.07
Nodes (25): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), byName(), collator (+17 more)

### Community 20 - "Dictionary"
Cohesion: 0.07
Nodes (16): Data, MeshCache, Info, ModelStore, Exported, MeshesPresent, MeshesWanted, PrefabsJson (+8 more)

### Community 21 - ".start"
Cohesion: 0.09
Nodes (6): App, BiomeHover, fromLatLng(), esc(), ForgeCard, T()

### Community 22 - "WebGLState"
Cohesion: 0.09
Nodes (50): setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), WebGLState(), activeTexture(), bindTexture(), ColorBuffer() (+42 more)

### Community 23 - "Stats"
Cohesion: 0.09
Nodes (9): What a regression would do on the live server, worst first, Boss, D, Kit, P, Spot, Standing, Stats (+1 more)

### Community 24 - "update"
Cohesion: 0.06
Nodes (49): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+41 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.07
Nodes (18): MapFog, Revision, ParticleSystem, ThreeDTests, Table, TablePin, Cat, Bush (+10 more)

### Community 27 - "get"
Cohesion: 0.10
Nodes (44): renderTarget(), WebGLCapabilities(), getMaxAnisotropy(), textureFormatReadable(), textureTypeReadable(), WebGLCubeMaps(), get(), mapTextureMapping() (+36 more)

### Community 29 - "measure.js"
Cohesion: 0.06
Nodes (16): rgb(), WorldEdgeGL, BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool (+8 more)

### Community 31 - "Features"
Cohesion: 0.09
Nodes (4): Feature, Features, Grids, Named

### Community 32 - "ForgeCanvas"
Cohesion: 0.06
Nodes (14): Tour, DeathsLayer, fogUsers, ForgeCanvas, loadFog(), MC, walkedFn(), PathsLayer (+6 more)

### Community 33 - "Audio"
Cohesion: 0.05
Nodes (4): Audio, AudioAnalyser, Controls, PositionalAudio

### Community 34 - "Material"
Cohesion: 0.05
Nodes (12): LineDashedMaterial, Material, MeshDepthMaterial, MeshDistanceMaterial, MeshMatcapMaterial, MeshNormalMaterial, MeshPhysicalMaterial, MeshStandardMaterial (+4 more)

### Community 35 - "Gear"
Cohesion: 0.07
Nodes (21): Armor, Heavy, Light, Mage, Medium, None, Diet, Balanced (+13 more)

### Community 36 - "activity.js"
Cohesion: 0.08
Nodes (17): ActivityLayers, colorRgb(), fmtAgo(), fmtClock(), fmtSpan(), gridOverlay(), HEAT, hslRgb() (+9 more)

### Community 37 - "Sphere"
Cohesion: 0.06
Nodes (5): ascSort(), Box2, Matrix2, Raycaster, Sphere

### Community 38 - ".constructor"
Cohesion: 0.08
Nodes (43): createCanvasElement(), createElementNS(), WebGLAnimation(), onAnimationFrame(), WebGLMaterials(), refreshFogUniforms(), refreshMaterialUniforms(), refreshTransformUniform() (+35 more)

### Community 40 - "playercard.js"
Cohesion: 0.09
Nodes (33): getJSON(), activityHtml(), ARMOR_SLOTS, at(), BIOME_COL, clock(), connHtml(), day() (+25 more)

### Community 41 - "ZDOID"
Cohesion: 0.10
Nodes (10): Deeds, DeedsGonePatch, DeedsRoutePatch, Kind, Kill, Rock, Tree, Last (+2 more)

### Community 43 - "Vegetation"
Cohesion: 0.09
Nodes (11): LocationTerrain, Count, Mod, Patch, Placed, Class, Point, Vegetation (+3 more)

### Community 44 - "leaflet.js"
Cohesion: 0.07
Nodes (24): at(), Ci(), d(), De(), ei(), ht(), i(), ii() (+16 more)

### Community 46 - ".distanceTo"
Cohesion: 0.06
Nodes (4): Frustum, Group, LOD, WebXRController

### Community 47 - "system_collections_generic"
Cohesion: 0.16
Nodes (3): WebMap.Util, WebMap.Models, WebMap.Tiles

### Community 48 - "AuthTests"
Cohesion: 0.09
Nodes (6): Auth, Session, HdMaps, AuthTests, HdMapsTests, Sink

### Community 49 - "Mesh"
Cohesion: 0.06
Nodes (9): ArrowHelper, BoxGeometry, Line, Mesh, MeshBasicMaterial, PlaneHelper, PointLightHelper, SkinnedMesh (+1 more)

### Community 50 - ".equals"
Cohesion: 0.08
Nodes (33): compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles(), filterPoints() (+25 more)

### Community 51 - ".render"
Cohesion: 0.07
Nodes (15): cloneUniforms(), getUnlitUniformColorSpace(), mergeUniforms(), PlaneGeometry, WebGLBackground(), addToRenderList(), dispose(), getBackground() (+7 more)

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "FogLayer"
Cohesion: 0.07
Nodes (8): ChunkStore, ObjectStore, parseVeg(), RegionLoader, VegStore, FogLayer, fetchEarly(), getBuffer()

### Community 55 - "PropertyBinding"
Cohesion: 0.07
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 57 - ".parseObject"
Cohesion: 0.06
Nodes (11): AmbientLight, DirectionalLight, Fog, FogExp2, HemisphereLight, Light, LightProbe, LineLoop (+3 more)

### Community 58 - "Color"
Cohesion: 0.08
Nodes (5): Color, damp(), euclideanModulo(), hue2rgb(), pingpong()

### Community 59 - "Quaternion"
Cohesion: 0.09
Nodes (3): 2.13.0, makeClipAdditive(), Quaternion

### Community 62 - "TileStore"
Cohesion: 0.10
Nodes (7): TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered, RenderMsTotal

### Community 63 - "markercanvas.js"
Cohesion: 0.10
Nodes (13): colors, asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache (+5 more)

### Community 64 - "Euler"
Cohesion: 0.09
Nodes (6): Euler, MeshLambertMaterial, MeshPhongMaterial, onQuaternionChange(), onRotationChange(), Scene

### Community 65 - "push"
Cohesion: 0.09
Nodes (26): ExternalTexture, ShadowUniformsCache(), UniformsCache(), WebGLLights(), setup(), setupView(), WebGLPrograms(), acquireProgram() (+18 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.11
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Discord"
Cohesion: 0.14
Nodes (6): Body, Discord, Token, DiscordRef, Result, DiscordTests

### Community 70 - "TileJob"
Cohesion: 0.14
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 71 - "Curve"
Cohesion: 0.09
Nodes (3): Curve, LineCurve, LineCurve3

### Community 72 - "PMREMGenerator"
Cohesion: 0.13
Nodes (12): RawShaderMaterial, ShaderMaterial, _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial(), PMREMGenerator, _setViewport() (+4 more)

### Community 73 - "Fact"
Cohesion: 0.17
Nodes (3): SettingsTests, StatsTests, VersionTests

### Community 74 - "Texture"
Cohesion: 0.08
Nodes (6): CanvasTexture, DepthTexture, FramebufferTexture, serializeImage(), Source, Texture

### Community 75 - "web/js/sky.js"
Cohesion: 0.10
Nodes (10): DARK, DAY, DUSK, GROUND, HAZE, lerp(), Lighting, NIGHT (+2 more)

### Community 76 - "RigBuilder"
Cohesion: 0.14
Nodes (13): HD, bakeSkin(), hdFor(), JOINT_ORDER, loadHd(), lookKey(), MR_METAL, MR_ROUGH (+5 more)

### Community 77 - ".constructor"
Cohesion: 0.07
Nodes (7): GLTFLoader, GLTFMaterialsBumpExtension, GLTFMaterialsEmissiveStrengthExtension, GLTFMaterialsIorExtension, GLTFMaterialsIridescenceExtension, GLTFMeshGpuInstancing, GLTFMeshoptCompression

### Community 78 - "KeyframeTrack"
Cohesion: 0.09
Nodes (7): BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, LinearInterpolant, QuaternionKeyframeTrack, StringKeyframeTrack, VectorKeyframeTrack

### Community 79 - "Items"
Cohesion: 0.15
Nodes (3): Items, Ready, ItemsTests

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "Func"
Cohesion: 0.13
Nodes (6): Entry, Given, Settings, Live, Stats, WorldEvents

### Community 83 - "LoadingManager"
Cohesion: 0.11
Nodes (11): 2.9.1, getTypedArray(), ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), intersect(), LoadingManager (+3 more)

### Community 84 - "JsonElement"
Cohesion: 0.15
Nodes (6): Testing, Entry, Last, Portals, PortalsTests, J

### Community 86 - "Loader"
Cohesion: 0.09
Nodes (9): AudioLoader, BufferGeometryLoader, CompressedTextureLoader, CubeTexture, CubeTextureLoader, DataTextureLoader, ImageLoader, Loader (+1 more)

### Community 87 - "WebGLProgram"
Cohesion: 0.08
Nodes (25): fetchAttributeLocations(), filterEmptyLine(), generateCubeUVSize(), generateDefines(), generateEnvMapBlendingDefine(), generateEnvMapModeDefine(), generateEnvMapTypeDefine(), generatePrecision() (+17 more)

### Community 88 - "HashSet"
Cohesion: 0.14
Nodes (8): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running

### Community 89 - "SerializedFile"
Cohesion: 0.22
Nodes (5): LeReader, ObjectInfo, SerializedFile, TypeInfo, TypeNode

### Community 90 - "GLTFParser"
Cohesion: 0.20
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "FeaturesTests"
Cohesion: 0.24
Nodes (3): FeaturesTests, Grid, Cell

### Community 92 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 93 - "RuinsGL"
Cohesion: 0.10
Nodes (6): hexRgb(), materialRgb(), PackedRegions, packRects(), RECT_LAYOUT(), RuinsGL

### Community 94 - "RaidLayer"
Cohesion: 0.18
Nodes (5): MapCore, ago(), areaCache, areaImage(), RaidLayer

### Community 95 - "WebMap"
Cohesion: 0.12
Nodes (4): DiscordWebHook, WebMap, ZNetPatchSetServer, ZoneSystemLoadPatch

### Community 96 - "web/js/view3d.js"
Cohesion: 0.13
Nodes (13): Street, _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), fallbackColor() (+5 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.17
Nodes (21): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+13 more)

### Community 99 - "BundleFile"
Cohesion: 0.16
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "AudioListener"
Cohesion: 0.11
Nodes (7): AudioContext, AudioListener, Clock, createColorManagement(), ImageUtils, LinearToSRGB(), SRGBToLinear()

### Community 104 - "Heights"
Cohesion: 0.17
Nodes (5): Heights, KeepSamples, Job, Served, Job

### Community 105 - "Using the map"
Cohesion: 0.10
Nodes (20): Chat commands, Checking the viewer against a live server, Coming from WebMap, Configuration, Discord, Features, Full-quality textures (optional), Install (+12 more)

### Community 108 - ".load"
Cohesion: 0.27
Nodes (4): handleError(), loadTexture(), loadTexture(), FileLoader

### Community 109 - "toLatLng"
Cohesion: 0.23
Nodes (3): ForgeMap 1.1.0, toLatLng(), PlayersLayer

### Community 110 - "MeshDecoder"
Cohesion: 0.23
Nodes (3): Decoded, MeshDecoder, MeshData

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.22
Nodes (3): GroundGL, perSide(), span()

### Community 114 - "Changelog"
Cohesion: 0.11
Nodes (17): 2.11.0, 2.14.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog (+9 more)

### Community 115 - "WebMap.cs"
Cohesion: 0.20
Nodes (3): DeathWatch, ZRoutedRpcPatch, ZRoutedRpcRoutePatch

### Community 117 - "TerrainPatches"
Cohesion: 0.20
Nodes (3): Patch, TerrainPatches, Count

### Community 118 - "arraysEqual"
Cohesion: 0.21
Nodes (19): allocTexUnits(), arraysEqual(), copyArray(), setValueM2(), setValueM3(), setValueM4(), setValueT1Array(), setValueT2DArrayArray() (+11 more)

### Community 119 - ".LookJson"
Cohesion: 0.20
Nodes (4): Item, Look, Rig, RigTests

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 125 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 126 - "WithDir"
Cohesion: 0.20
Nodes (3): PinsTests, File_, WithDir

### Community 127 - "ContourGL"
Cohesion: 0.18
Nodes (3): ContourGL, labelImage(), span()

### Community 128 - ".load"
Cohesion: 0.14
Nodes (5): getImageURIMimeType(), GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension, LoaderUtils

### Community 129 - "AnimationClip"
Cohesion: 0.15
Nodes (3): AnimationClip, AnimationUtils, NumberKeyframeTrack

### Community 130 - "CubicBezierCurve"
Cohesion: 0.12
Nodes (7): CubicBezier(), CubicBezierCurve, CubicBezierCurve3, CubicBezierP0(), CubicBezierP1(), CubicBezierP2(), CubicBezierP3()

### Community 131 - "Ping"
Cohesion: 0.15
Nodes (4): Ping, ZNetPatchDisconnect, ZNetPatchStart, ZRoutedRpcAddPeerPatch

### Community 133 - "Material"
Cohesion: 0.12
Nodes (16): Material, Ashwood, BlackMarble, Cloth, CoreWood, Crystal, DarkWood, Fire (+8 more)

### Community 134 - ".build"
Cohesion: 0.23
Nodes (3): drawPicture(), ShapeCache, vegShowMask()

### Community 135 - "k"
Cohesion: 0.17
Nodes (16): F(), G(), h(), j(), Jt(), k(), ke(), ne() (+8 more)

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - "LightShadow"
Cohesion: 0.13
Nodes (3): DirectionalLightShadow, LightShadow, PointLightShadow

### Community 138 - "QuadraticBezierCurve"
Cohesion: 0.12
Nodes (6): QuadraticBezier(), QuadraticBezierCurve, QuadraticBezierCurve3, QuadraticBezierP0(), QuadraticBezierP1(), QuadraticBezierP2()

### Community 139 - "Png"
Cohesion: 0.19
Nodes (6): Format, Gray16, Gray8, RGB, RGBA, Png

### Community 140 - "Français"
Cohesion: 0.13
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 141 - "i18n.js"
Cohesion: 0.17
Nodes (7): Gear, fill(), has(), num(), t(), tn(), translateTree()

### Community 143 - "Interpolant"
Cohesion: 0.18
Nodes (3): CubicInterpolant, DiscreteInterpolant, Interpolant

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 146 - "ChatRelay"
Cohesion: 0.26
Nodes (3): ChatRelay, DiscordMessage, ChatRelayTests

### Community 148 - "RenderTarget"
Cohesion: 0.20
Nodes (4): Data3DTexture, RenderTarget, RenderTarget3D, WebGL3DRenderTarget

### Community 151 - "check.mjs"
Cohesion: 0.32
Nodes (11): [BASE, PORT, OUT], check(), map(), open(), plan(), players(), portals(), sleep() (+3 more)

### Community 153 - "parseUniform"
Cohesion: 0.17
Nodes (7): addUniform(), getPureArraySetter(), getSingularSetter(), parseUniform(), PureArrayUniform, SingleUniform, StructuredUniform

### Community 154 - "bench.mjs"
Cohesion: 0.22
Nodes (10): 2.12.0, [BASE, PORT], errors, ev(), ms(), pending, send(), tab (+2 more)

### Community 159 - "SmoothZoom"
Cohesion: 0.36
Nodes (3): SmoothZoom, SmoothZoomControl, update()

### Community 160 - "vegpack.js"
Cohesion: 0.25
Nodes (9): packTrees(), radiusOf(), RGB, seedOf(), SMALL_R, TREE_STRIDE, unpackRegion(), VEG (+1 more)

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 170 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

### Community 171 - "addShape"
Cohesion: 0.36
Nodes (9): addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3(), f4(), sidewalls() (+1 more)

### Community 175 - "Announce"
Cohesion: 0.32
Nodes (3): Announce, Token, Pending

### Community 176 - "m"
Cohesion: 0.36
Nodes (8): e(), hi(), m(), Qe(), ve(), xe(), ye(), z()

### Community 178 - "CompressedTexture"
Cohesion: 0.25
Nodes (3): CompressedArrayTexture, CompressedCubeTexture, CompressedTexture

### Community 180 - "WebMap.Tests.csproj"
Cohesion: 0.29
Nodes (5): net10.0, Microsoft.NET.Test.Sdk (17.14.1), xunit (2.9.3), xunit.runner.visualstudio (3.1.4), Microsoft.NET.Sdk

### Community 181 - "WebMap.csproj"
Cohesion: 0.29
Nodes (6): net48, ILRepack.Lib.MSBuild.Task (2.0.44.2), Krafs.Publicizer (2.2.1), Microsoft.NETFramework.ReferenceAssemblies (1.0.3), SixLabors.ImageSharp (2.1.13), Microsoft.NET.Sdk

### Community 184 - "render"
Cohesion: 0.43
Nodes (4): load(), message(), render(), Spot

### Community 185 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 187 - ".parse"
Cohesion: 0.29
Nodes (3): AnimationLoader, getTrackTypeForValueTypeName(), parseKeyframeTrack()

### Community 191 - "flatten"
Cohesion: 0.29
Nodes (7): flatten(), setValueM2Array(), setValueM3Array(), setValueM4Array(), setValueV2fArray(), setValueV3fArray(), setValueV4fArray()

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 197 - "be"
Cohesion: 0.33
Nodes (6): Ae(), be(), Ie(), Le(), O(), Re()

### Community 203 - "bi"
Cohesion: 0.40
Nodes (5): ForgeMap 1.2.0, bi(), Pi(), Ti(), u()

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

## Knowledge Gaps
- **210 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+205 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1898 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **87 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `List`, `StructureMap`, `ChatRelay`, `WorldObjects`, `View3D`, `Features`, `Timer`, `ZDOID`, `Trails`, `AuthTests`, `Discord`, `Fact`, `MapDataServer`, `JsonElement`, `WebMap`, `Changelog`, `WebMap.cs`, `.ProcessSpecialRoutes`, `TerrainPatches`?**
  _High betweenness centrality (0.314) - this node is a cross-community bridge._
- **Are the 7 inferred relationships involving `get()` (e.g. with `WebGLAttributes()` and `WebGLCubeMaps()`) actually correct?**
  _`get()` has 7 INFERRED edges - model-reasoned connections that need verification._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _210 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.008064516129032258 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `Timer` to `three.core.js`, `three.module.js`, `EventDispatcher`, `Stats`?**
  _High betweenness centrality (0.253) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.00819672131147541 - nodes in this community are weakly interconnected._
- **Why does `View3D` connect `View3D` to `web/js/view3d.js`, `web/js/sky.js`, `.canopyMaterial`?**
  _High betweenness centrality (0.085) - this node is a cross-community bridge._