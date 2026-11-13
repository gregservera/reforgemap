# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 213 files · ~708,255 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6659 nodes · 16073 edges · 249 communities (159 shown, 90 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 783 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `7f84ced2`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- three.core.js
- three.module.js
- BufferGeometry
- app.js
- .copy
- Matrix4
- Vector3
- BatchedMesh
- ForestMap
- ui.js
- .Export
- View3D
- Vegetation
- OrbitControls
- BufferAttribute
- xunit
- .parseObject
- WebGLRenderer
- Markers
- markers.js
- Dictionary
- .start
- .toArray
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
- Mesh
- leaflet.js
- Vehicles
- WebXRController
- .Sweep
- AuthTests
- Float32BufferAttribute
- .equals
- WebXRManager
- Vector4
- Veg
- net.js
- PropertyBinding
- WithDir
- Light
- Color
- Quaternion
- Box3
- GateTests
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
- Dictionary
- Texture
- web/js/sky.js
- RigBuilder
- .constructor
- KeyframeTrack
- Items
- MapDataServer
- .assignTexture
- .fromBufferAttribute
- LoadingManager
- addToRenderList
- AnimationMixer
- OrbitControls.js
- WebGLProgram
- HashSet
- SerializedFile
- GLTFParser
- Fact
- MigrationTests
- ChunkShapes
- RaidLayer
- Activity
- web/js/view3d.js
- Matrix3
- WebGLBindingStates
- BundleFile
- package.json
- Clock
- Path
- BiomeMap
- Heights
- Using the map
- Pieces
- PropertyMixer
- Loader
- toLatLng
- MeshDecoder
- Hand
- GroundGL
- FogLayer
- Changelog
- WorldEvents
- TerrainPatches
- Structures
- arraysEqual
- .LookJson
- map-core.test.mjs
- Locations
- BuildingsGL
- Deeds
- .distanceTo
- particles.js
- portrait.js
- ContourGL
- .load
- AnimationClip
- CubicBezierCurve
- onTouchMove
- PinsTests
- Timer
- .constructor
- .update
- BufferGeometryUtils.js
- .clone
- QuadraticBezierCurve
- Png
- Français
- i18n.js
- PerspectiveCamera
- JsonElement
- PolyhedronGeometry
- InterleavedBuffer
- Feed
- Layers
- WebMap.cs
- AltBiomeGL
- CompressedTexture
- check.mjs
- Func
- parseUniform
- bench.mjs
- TextureDecoder
- .canopyMaterial
- MistGL
- FallbackTileLayer
- SmoothZoom
- WebGLPrograms
- .parse
- .push
- .RefreshPlayerSnapshot
- SphereGeometry
- VideoTexture
- .Verify
- WebP
- WebGLState
- BiomeGL
- Preview
- p
- ServerLog
- ShapesCanvas
- .build
- ZNetPeer
- m
- EllipseCurve
- Material
- Spherical
- WebMap.Tests.csproj
- WebMap.csproj
- CubicPoly
- Window
- render
- HashSet
- getKeyframeOrder
- GLTFMaterialsDispersionExtension
- Cylindrical
- GLBufferAttribute
- Object3D
- ChatRelay
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- k
- ChatCommands
- .NewWorld
- MeshPhysicalMaterial
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- PositionalAudio
- .Of
- .Start
- bi
- Third-party notices
- WebMap.Models
- .load
- vegpack.js
- TextureUtils
- .constructor
- testserver.sh
- .connect
- MultiDrawRenderList
- Uniform
- layers.js
- .FromSerialized
- GuideGL
- PlanLayer
- MuninShims.cs
- probeAsync
- FogGL
- .constructor
- Armor
- BoxHelper
- worldkeys.js
- Clock
- CylinderGeometry
- AudioAnalyser
- BoxGeometry
- .constructor
- StaticFilesTests
- CatmullRom
- Int16BufferAttribute
- Int32BufferAttribute
- Int8BufferAttribute
- Uint16BufferAttribute
- Uint32BufferAttribute
- Uint8BufferAttribute
- Uint8ClampedBufferAttribute

## God Nodes (most connected - your core abstractions)
1. `Vector3` - 114 edges
2. `Vector2` - 89 edges
3. `get()` - 88 edges
4. `MapDataServer` - 77 edges
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

## Communities (249 total, 90 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (218): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+210 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (38): InterpolationSamplingMode, TimestampQuery, TOUCH, UniformsUtils, arrayCacheF32, arrayCacheI32, _axisDirections, _clearColor (+30 more)

### Community 2 - "BufferGeometry"
Cohesion: 0.05
Nodes (15): buildPlane(), BufferGeometry, convertBufferAttribute(), CapsuleGeometry, CircleGeometry, copyArrayContents(), generateCap(), generateTorso() (+7 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (83): BiomeHover, chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM (+75 more)

### Community 4 - ".copy"
Cohesion: 0.05
Nodes (12): a(), c(), x(), handleTriangle(), handleVertex(), checkGeometryIntersection(), checkIntersection$1(), isUniqueEdge() (+4 more)

### Community 5 - "Matrix4"
Cohesion: 0.05
Nodes (4): Camera, CubeCamera, Matrix4, OrthographicCamera

### Community 7 - "BatchedMesh"
Cohesion: 0.06
Nodes (7): ascIdSort(), BatchedMesh, checkIntersection(), InstancedBufferAttribute, InstancedMesh, Matrix2, testPoint()

### Community 8 - "ForestMap"
Cohesion: 0.14
Nodes (8): Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump, Tree

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (58): iconSvg(), escape(), makeIcon(), statsHtml(), BIOME_SVG, breakable(), BUILD_SVG, BUSH_SVG (+50 more)

### Community 10 - ".Export"
Cohesion: 0.06
Nodes (13): Kind, GlbWriter, Count, Node, Primitive, Skin, PrefabExporter, Result (+5 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (13): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+5 more)

### Community 12 - "Vegetation"
Cohesion: 0.13
Nodes (7): Class, Crunched, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.11
Nodes (4): onMouseDown(), onMouseWheel(), onPointerDown(), OrbitControls

### Community 14 - "BufferAttribute"
Cohesion: 0.05
Nodes (7): BufferAttribute, copyAttributeData(), DataUtils, denormalize(), Float16BufferAttribute, InterleavedBufferAttribute, _createPlanes()

### Community 16 - ".parseObject"
Cohesion: 0.07
Nodes (14): getArrayBuffer(), getInterleavedBuffer(), DataTexture, Fog, FogExp2, getTypedArray(), LightProbe, LineLoop (+6 more)

### Community 17 - "WebGLRenderer"
Cohesion: 0.08
Nodes (12): WebGLRenderTarget, WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLRenderer, renderObject(), renderObjects(), renderScene() (+4 more)

### Community 18 - "Markers"
Cohesion: 0.06
Nodes (12): BaseOverride, BedSpot, Findable, Markers, Json, Rev, Portal, SignSpot (+4 more)

### Community 19 - "markers.js"
Cohesion: 0.06
Nodes (28): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), byName(), collator (+20 more)

### Community 20 - "Dictionary"
Cohesion: 0.09
Nodes (15): Data, MeshCache, Info, ModelStore, Exported, MeshesPresent, MeshesWanted, PrefabsJson (+7 more)

### Community 21 - ".start"
Cohesion: 0.09
Nodes (7): App, fromLatLng(), esc(), ForgeCard, T(), weatherWord(), windWord()

### Community 22 - ".toArray"
Cohesion: 0.10
Nodes (5): Bone, CatmullRomCurve3, flattenJSON(), Skeleton, SplineCurve

### Community 23 - "Stats"
Cohesion: 0.08
Nodes (9): What a regression would do on the live server, worst first, Boss, D, Kit, P, Spot, Standing, Stats (+1 more)

### Community 24 - "update"
Cohesion: 0.06
Nodes (49): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+41 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.07
Nodes (16): MapFog, Revision, ParticleSystem, ThreeDTests, Cat, Bush, Other, Piece (+8 more)

### Community 27 - "get"
Cohesion: 0.09
Nodes (66): createElementNS(), setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), WebGLCapabilities(), getMaxAnisotropy(), textureFormatReadable() (+58 more)

### Community 29 - "measure.js"
Cohesion: 0.06
Nodes (16): rgb(), WorldEdgeGL, BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool (+8 more)

### Community 30 - "system"
Cohesion: 0.12
Nodes (3): WebMap.Util, WebMap, WebMap.Tiles

### Community 31 - "Features"
Cohesion: 0.11
Nodes (4): Feature, Features, Grids, Named

### Community 32 - "ForgeCanvas"
Cohesion: 0.09
Nodes (10): Tour, DeathsLayer, fogUsers, ForgeCanvas, loadFog(), MC, walkedFn(), PathsLayer (+2 more)

### Community 34 - "Material"
Cohesion: 0.06
Nodes (11): LineDashedMaterial, Material, MeshDepthMaterial, MeshDistanceMaterial, MeshMatcapMaterial, MeshNormalMaterial, MeshPhongMaterial, MeshToonMaterial (+3 more)

### Community 35 - "Gear"
Cohesion: 0.08
Nodes (15): Diet, Balanced, Eitr, Hearty, None, Quick, Gear, Hit (+7 more)

### Community 36 - "activity.js"
Cohesion: 0.08
Nodes (17): ActivityLayers, colorRgb(), fmtAgo(), fmtClock(), fmtSpan(), gridOverlay(), HEAT, hslRgb() (+9 more)

### Community 38 - ".constructor"
Cohesion: 0.14
Nodes (23): WebGLMaterials(), refreshFogUniforms(), refreshMaterialUniforms(), refreshTransformUniform(), refreshUniformsCommon(), refreshUniformsDash(), refreshUniformsDistance(), refreshUniformsLine() (+15 more)

### Community 40 - "playercard.js"
Cohesion: 0.12
Nodes (22): stats, activityHtml(), ARMOR_SLOTS, at(), BIOME_COL, clock(), connHtml(), day() (+14 more)

### Community 41 - "ZDOID"
Cohesion: 0.08
Nodes (15): DeedsRoutePatch, Kitchen, Made, Brewed, Burnt, Cooked, Honey, Smelted (+7 more)

### Community 42 - "JsonWriter"
Cohesion: 0.12
Nodes (3): PartTimer, JsonWriter, Length

### Community 43 - "Mesh"
Cohesion: 0.08
Nodes (4): FrustumArray, Mesh, Ray, SkinnedMesh

### Community 44 - "leaflet.js"
Cohesion: 0.08
Nodes (18): at(), Ci(), d(), ht(), i(), Jt(), l(), Le() (+10 more)

### Community 45 - "Vehicles"
Cohesion: 0.11
Nodes (8): Entry, Traders, Entry, Kind, Boat, Cart, None, Vehicles

### Community 46 - "WebXRController"
Cohesion: 0.10
Nodes (3): Group, UniformsGroup, WebXRController

### Community 47 - ".Sweep"
Cohesion: 0.04
Nodes (25): Entry, Graves, Demisters, Dungeons, Signature, Inside, Visited, Kind (+17 more)

### Community 49 - "Float32BufferAttribute"
Cohesion: 0.06
Nodes (15): ArrowHelper, AxesHelper, Box3Helper, Float32BufferAttribute, getBoneList(), GridHelper, HemisphereLightHelper, Line (+7 more)

### Community 50 - ".equals"
Cohesion: 0.09
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebXRManager"
Cohesion: 0.06
Nodes (12): ArrayCamera, WebGLAnimation(), onAnimationFrame(), onAnimationFrame(), WebXRDepthSensing, WebXRManager, onInputSourcesChange(), onSessionEnd() (+4 more)

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "net.js"
Cohesion: 0.06
Nodes (18): ChunkStore, ObjectStore, parseVeg(), RegionLoader, VegStore, RuinsLayer, RuinStore, connect() (+10 more)

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "WithDir"
Cohesion: 0.09
Nodes (5): WebMapConfig, HeightMaxZoom, HdMapsTests, Sink, LightModeTests

### Community 57 - "Light"
Cohesion: 0.13
Nodes (4): AmbientLight, HemisphereLight, Light, RectAreaLight

### Community 58 - "Color"
Cohesion: 0.07
Nodes (8): Color, createColorManagement(), damp(), euclideanModulo(), hue2rgb(), LinearToSRGB(), pingpong(), SRGBToLinear()

### Community 62 - "TileStore"
Cohesion: 0.08
Nodes (9): TileMath, ChunksPerSide, TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered (+1 more)

### Community 63 - "markercanvas.js"
Cohesion: 0.11
Nodes (12): asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache, labelImage() (+4 more)

### Community 64 - "Euler"
Cohesion: 0.10
Nodes (5): Euler, MeshLambertMaterial, onQuaternionChange(), onRotationChange(), Scene

### Community 65 - "push"
Cohesion: 0.09
Nodes (22): renderTarget(), ExternalTexture, shadowCastingAndTexturingLightsFirst(), ShadowUniformsCache(), UniformsCache(), WebGLLights(), setup(), setupView() (+14 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

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
Nodes (11): RawShaderMaterial, ShaderMaterial, _createRenderTarget(), _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial(), PMREMGenerator (+3 more)

### Community 73 - "Dictionary"
Cohesion: 0.10
Nodes (6): HotspotsTests, BuildHistory, Snap, Hotspots, Json, JsonParser

### Community 74 - "Texture"
Cohesion: 0.05
Nodes (12): CanvasTexture, CubeTexture, Data3DTexture, DataArrayTexture, DepthTexture, FramebufferTexture, RenderTarget, RenderTarget3D (+4 more)

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
Cohesion: 0.06
Nodes (11): BooleanKeyframeTrack, ColorKeyframeTrack, CubicInterpolant, DiscreteInterpolant, Interpolant, KeyframeTrack, LinearInterpolant, QuaternionKeyframeTrack (+3 more)

### Community 79 - "Items"
Cohesion: 0.10
Nodes (4): Items, Ready, ItemsTests, WithDir

### Community 80 - "MapDataServer"
Cohesion: 0.07
Nodes (4): MapDataServer, PlayersWs, MapMessage, WebSocketHandler

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 83 - "LoadingManager"
Cohesion: 0.11
Nodes (6): EventDispatcher, ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), LoadingManager

### Community 84 - "addToRenderList"
Cohesion: 0.27
Nodes (10): cloneUniforms(), cloneUniformsGroups(), getUnlitUniformColorSpace(), mergeUniforms(), WebGLBackground(), addToRenderList(), dispose(), getBackground() (+2 more)

### Community 86 - "OrbitControls.js"
Cohesion: 0.11
Nodes (11): PlayerCard, MapControls, _changeEvent, _endEvent, onPointerUp(), _plane, _ray, _startEvent (+3 more)

### Community 87 - "WebGLProgram"
Cohesion: 0.08
Nodes (26): fetchAttributeLocations(), filterEmptyLine(), generateCubeUVSize(), generateDefines(), generateEnvMapBlendingDefine(), generateEnvMapModeDefine(), generateEnvMapTypeDefine(), generatePrecision() (+18 more)

### Community 88 - "HashSet"
Cohesion: 0.19
Nodes (4): TextureExtractor, LastFound, LastReport, Running

### Community 89 - "SerializedFile"
Cohesion: 0.22
Nodes (5): LeReader, ObjectInfo, SerializedFile, TypeInfo, TypeNode

### Community 90 - "GLTFParser"
Cohesion: 0.20
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.12
Nodes (6): FeaturesTests, SettingsTests, Grid, Cell, TilesTests, VersionTests

### Community 92 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 94 - "RaidLayer"
Cohesion: 0.18
Nodes (5): MapCore, ago(), areaCache, areaImage(), RaidLayer

### Community 95 - "Activity"
Cohesion: 0.24
Nodes (4): Activity, Snap, Trail, ActivityTests

### Community 96 - "web/js/view3d.js"
Cohesion: 0.13
Nodes (13): Street, _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), fallbackColor() (+5 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.13
Nodes (22): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+14 more)

### Community 99 - "BundleFile"
Cohesion: 0.14
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "Clock"
Cohesion: 0.15
Nodes (4): AudioContext, AudioListener, ImageUtils, serializeImage()

### Community 104 - "Heights"
Cohesion: 0.18
Nodes (5): Heights, KeepSamples, Job, Served, Job

### Community 105 - "Using the map"
Cohesion: 0.11
Nodes (18): Chat commands, Checking the viewer against a live server, Configuration, Discord, Features, Full-quality textures (optional), Licence and credit, Local test server (+10 more)

### Community 106 - "Pieces"
Cohesion: 0.18
Nodes (5): Testing, Entry, Kind, Pieces, PiecesTests

### Community 108 - "Loader"
Cohesion: 0.09
Nodes (14): AnimationLoader, AudioLoader, handleError(), BufferGeometryLoader, CompressedTextureLoader, loadTexture(), CubeTextureLoader, loadTexture() (+6 more)

### Community 109 - "toLatLng"
Cohesion: 0.20
Nodes (4): ForgeMap 1.1.0, toLatLng(), PALETTE, PlayersLayer

### Community 110 - "MeshDecoder"
Cohesion: 0.23
Nodes (3): Decoded, MeshDecoder, MeshData

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.21
Nodes (4): GroundGL, perSide(), span(), screenArea()

### Community 114 - "Changelog"
Cohesion: 0.11
Nodes (17): 2.11.0, 2.14.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog (+9 more)

### Community 115 - "WorldEvents"
Cohesion: 0.13
Nodes (7): Peak, Peaks, All, ZNetPatchStart, WorldEvents, InvasionsPath, StatePath

### Community 116 - "TerrainPatches"
Cohesion: 0.24
Nodes (3): Patch, TerrainPatches, Count

### Community 117 - "Structures"
Cohesion: 0.04
Nodes (22): HdMaps, ChunkCache, Line, Regions, Chunk, Ruins, IndexJson, LastChanged (+14 more)

### Community 118 - "arraysEqual"
Cohesion: 0.21
Nodes (19): allocTexUnits(), arraysEqual(), copyArray(), setValueM2(), setValueM3(), setValueM4(), setValueT1Array(), setValueT2DArrayArray() (+11 more)

### Community 119 - ".LookJson"
Cohesion: 0.22
Nodes (4): Item, Look, Rig, RigTests

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 122 - "BuildingsGL"
Cohesion: 0.09
Nodes (7): BuildingsGL, hexRgb(), materialRgb(), PackedRegions, packRects(), RECT_LAYOUT(), RuinsGL

### Community 123 - "Deeds"
Cohesion: 0.15
Nodes (8): Deeds, DeedsGonePatch, Kind, Kill, Rock, Tree, Last, DeedsTests

### Community 125 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 126 - "portrait.js"
Cohesion: 0.26
Nodes (11): bodyTexture(), curlNoise(), finish(), image(), info(), lib(), model(), models (+3 more)

### Community 127 - "ContourGL"
Cohesion: 0.18
Nodes (3): ContourGL, labelImage(), span()

### Community 128 - ".load"
Cohesion: 0.14
Nodes (5): getImageURIMimeType(), GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension, LoaderUtils

### Community 129 - "AnimationClip"
Cohesion: 0.10
Nodes (8): Coming from WebMap, Install, AnimationClip, AnimationUtils, getTrackTypeForValueTypeName(), NumberKeyframeTrack, parseKeyframeTrack(), subclip()

### Community 130 - "CubicBezierCurve"
Cohesion: 0.12
Nodes (7): CubicBezier(), CubicBezierCurve, CubicBezierCurve3, CubicBezierP0(), CubicBezierP1(), CubicBezierP2(), CubicBezierP3()

### Community 134 - ".constructor"
Cohesion: 0.09
Nodes (31): createCanvasElement(), WebGLCubeRenderTarget, WebGLCubeMaps(), get(), mapTextureMapping(), onTextureDispose(), WebGLCubeUVMaps(), dispose() (+23 more)

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - ".clone"
Cohesion: 0.04
Nodes (9): DirectionalLight, DirectionalLightShadow, scalePt2(), LightShadow, Line3, PointLight, PointLightShadow, SpotLight (+1 more)

### Community 138 - "QuadraticBezierCurve"
Cohesion: 0.12
Nodes (6): QuadraticBezier(), QuadraticBezierCurve, QuadraticBezierCurve3, QuadraticBezierP0(), QuadraticBezierP1(), QuadraticBezierP2()

### Community 139 - "Png"
Cohesion: 0.18
Nodes (6): Format, Gray16, Gray8, RGB, RGBA, Png

### Community 140 - "Français"
Cohesion: 0.13
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 141 - "i18n.js"
Cohesion: 0.17
Nodes (7): Gear, fill(), has(), num(), t(), tn(), translateTree()

### Community 143 - "JsonElement"
Cohesion: 0.15
Nodes (5): Entry, Last, Portals, PortalsTests, J

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 145 - "InterleavedBuffer"
Cohesion: 0.12
Nodes (3): generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer

### Community 146 - "Feed"
Cohesion: 0.21
Nodes (6): Ev, Feed, Keep, RecentJson, FeedTests, SkipToMorningPatch

### Community 147 - "Layers"
Cohesion: 0.12
Nodes (5): 2.9.1, ascSort(), intersect(), Layers, Raycaster

### Community 148 - "WebMap.cs"
Cohesion: 0.32
Nodes (3): DeathWatch, ZRoutedRpcPatch, ZRoutedRpcRoutePatch

### Community 150 - "CompressedTexture"
Cohesion: 0.25
Nodes (3): CompressedArrayTexture, CompressedCubeTexture, CompressedTexture

### Community 151 - "check.mjs"
Cohesion: 0.32
Nodes (11): [BASE, PORT, OUT], check(), map(), open(), plan(), players(), portals(), sleep() (+3 more)

### Community 152 - "Func"
Cohesion: 0.18
Nodes (3): Entry, Given, Settings

### Community 153 - "parseUniform"
Cohesion: 0.17
Nodes (7): addUniform(), getPureArraySetter(), getSingularSetter(), parseUniform(), PureArrayUniform, SingleUniform, StructuredUniform

### Community 154 - "bench.mjs"
Cohesion: 0.22
Nodes (10): 2.12.0, [BASE, PORT], errors, ev(), ms(), pending, send(), tab (+2 more)

### Community 159 - "SmoothZoom"
Cohesion: 0.36
Nodes (3): SmoothZoom, SmoothZoomControl, update()

### Community 160 - "WebGLPrograms"
Cohesion: 0.15
Nodes (10): getMaxPrecision(), WebGLPrograms(), dispose(), getChannel(), getParameters(), getProgramCacheKey(), getProgramCacheKeyBooleans(), getProgramCacheKeyParameters() (+2 more)

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 162 - ".push"
Cohesion: 0.05
Nodes (26): CurvePath, ExtrudeGeometry, addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3() (+18 more)

### Community 168 - "WebGLState"
Cohesion: 0.23
Nodes (17): WebGLState(), ColorBuffer(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), reset(), scissor() (+9 more)

### Community 169 - "BiomeGL"
Cohesion: 0.22
Nodes (3): 2.13.0, bigText(), BiomeGL

### Community 171 - "p"
Cohesion: 0.17
Nodes (13): Ae(), be(), De(), ei(), Ie(), ii(), Je(), ni() (+5 more)

### Community 172 - "ServerLog"
Cohesion: 0.27
Nodes (3): Line, ServerLog, ZNetPatchShutdown

### Community 175 - "ZNetPeer"
Cohesion: 0.07
Nodes (9): Announce, Token, Pending, DiscordWebHook, WebMap, ZNetPatchDisconnect, ZNetPatchSetServer, ZoneSystemLoadPatch (+1 more)

### Community 176 - "m"
Cohesion: 0.36
Nodes (8): e(), hi(), m(), Qe(), ve(), xe(), ye(), z()

### Community 178 - "Material"
Cohesion: 0.12
Nodes (16): Material, Ashwood, BlackMarble, Cloth, CoreWood, Crystal, DarkWood, Fire (+8 more)

### Community 180 - "WebMap.Tests.csproj"
Cohesion: 0.29
Nodes (5): net10.0, Microsoft.NET.Test.Sdk (17.14.1), xunit (2.9.3), xunit.runner.visualstudio (3.1.4), Microsoft.NET.Sdk

### Community 181 - "WebMap.csproj"
Cohesion: 0.29
Nodes (6): net48, ILRepack.Lib.MSBuild.Task (2.0.44.2), Krafs.Publicizer (2.2.1), Microsoft.NETFramework.ReferenceAssemblies (1.0.3), SixLabors.ImageSharp (2.1.13), Microsoft.NET.Sdk

### Community 184 - "render"
Cohesion: 0.43
Nodes (4): load(), message(), render(), Spot

### Community 185 - "HashSet"
Cohesion: 0.20
Nodes (3): Cell, StructureMap, Floor

### Community 190 - "Object3D"
Cohesion: 0.07
Nodes (3): Object3D, _points, Sprite

### Community 191 - "ChatRelay"
Cohesion: 0.26
Nodes (3): ChatRelay, DiscordMessage, ChatRelayTests

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 194 - "k"
Cohesion: 0.20
Nodes (14): F(), G(), h(), j(), k(), ke(), me(), ne() (+6 more)

### Community 195 - "ChatCommands"
Cohesion: 0.22
Nodes (7): ChatCommands, Command, Kind, Delete, None, Pin, Undo

### Community 196 - ".NewWorld"
Cohesion: 0.23
Nodes (3): 2.10.0, ImageConv, Texture2D

### Community 202 - ".Start"
Cohesion: 0.18
Nodes (3): StaticCoroutine, StaticCoroutineRunner, ZoneSystemPatch

### Community 203 - "bi"
Cohesion: 0.40
Nodes (5): ForgeMap 1.2.0, bi(), Pi(), Ti(), u()

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 207 - "vegpack.js"
Cohesion: 0.23
Nodes (10): packTrees(), radiusOf(), RGB, seedOf(), SMALL_R, TREE_STRIDE, unpackRegion(), VEG (+2 more)

### Community 209 - ".constructor"
Cohesion: 0.30
Nodes (11): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+3 more)

### Community 215 - ".FromSerialized"
Cohesion: 0.24
Nodes (4): MeshExtractor, LastFound, LastReport, Running

### Community 216 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

### Community 218 - "MuninShims.cs"
Cohesion: 0.29
Nodes (3): Live, Stats, WorldEvents

### Community 223 - ".constructor"
Cohesion: 0.43
Nodes (3): CameraHelper, addLine(), addPoint()

### Community 224 - "Armor"
Cohesion: 0.33
Nodes (6): Armor, Heavy, Light, Mage, Medium, None

## Knowledge Gaps
- **215 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+210 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1913 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **90 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `Timer`, `ForestMap`, `JsonElement`, `WebMap.cs`, `WorldObjects`, `View3D`, `Features`, `.RefreshPlayerSnapshot`, `.Verify`, `ZDOID`, `ZNetPeer`, `HashSet`, `ChatRelay`, `Discord`, `.Of`, `MapDataServer`, `Pieces`, `Changelog`, `TerrainPatches`, `Deeds`?**
  _High betweenness centrality (0.324) - this node is a cross-community bridge._
- **Are the 7 inferred relationships involving `get()` (e.g. with `WebGLAttributes()` and `WebGLCubeMaps()`) actually correct?**
  _`get()` has 7 INFERRED edges - model-reasoned connections that need verification._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _215 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.008032128514056224 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `Timer` to `three.core.js`, `three.module.js`, `LoadingManager`, `Stats`?**
  _High betweenness centrality (0.279) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.008260415306255714 - nodes in this community are weakly interconnected._
- **Why does `initGLContext()` connect `.constructor` to `WebGLPrograms`, `push`, `WebGLBindingStates`, `.constructor`, `WebGLState`, `WebGLRenderer`, `addToRenderList`, `update`, `get`, `portrait.js`?**
  _High betweenness centrality (0.073) - this node is a cross-community bridge._