# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 232 files · ~733,943 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6988 nodes · 17001 edges · 231 communities (154 shown, 77 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 869 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `949694b2`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- three.core.js
- three.module.js
- .push
- app.js
- .subVectors
- WebXRController
- Vector3
- Object3D
- Vector3
- ui.js
- unityengine
- View3D
- Vegetation
- OrbitControls
- BufferAttribute
- xunit
- TourCam
- BatchedMesh
- Markers
- markers.js
- Dictionary
- .start
- get
- Stats
- update
- textures-hd.py
- WorldObjects
- WebGLShaderCache
- View3D
- measure.js
- system_collections_generic
- Features
- ForgeCanvas
- Audio
- Material
- Gear
- activity.js
- Func
- .constructor
- Vector2
- .compileAsync
- PrefabExporter
- JsonWriter
- .Sweep
- leaflet.js
- WebXRManager
- .applyMatrix4
- TileMath
- AuthTests
- Pieces
- .equals
- WebXRManager
- Vector4
- Veg
- net.js
- PropertyBinding
- Euler
- Matrix4
- Color
- Quaternion
- Box3
- GateTests
- TileStore
- markercanvas.js
- .Export
- push
- GLTFLoader.js
- InlineData
- Func
- AnimationAction
- TileJob
- Curve
- PMREMGenerator
- Loader
- Matrix3
- web/js/sky.js
- RigBuilder
- .constructor
- KeyframeTrack
- Items
- MapDataServer
- .assignTexture
- TextureExtractor
- WebMap
- ChunkShapes
- AnimationMixer
- BundleFile
- ItemIcons
- HashSet
- SerializedFile
- GLTFParser
- Fact
- GateTests
- .Verify
- GlbWriter
- Activity
- web/js/view3d.js
- WebGLState
- WebGLBindingStates
- BundleFile
- package.json
- ModelStore
- Path
- BiomeMap
- TerrainPatches
- Using the map
- List
- PropertyMixer
- Part
- RaidLayer
- .FromSerialized
- Hand
- GroundGL
- Texture
- Changelog
- Raycaster
- MeshDecoder
- Structures
- arraysEqual
- .LookJson
- map-core.test.mjs
- Locations
- Dictionary
- MeshPhysicalMaterial
- Interpolant
- InterleavedBuffer
- .Encode
- ContourGL
- .load
- AnimationClip
- system_io
- particles.js
- Fact
- MigrationTests
- .update
- TextureDecoder
- BufferGeometryUtils.js
- m
- Français
- Kitchen
- PerspectiveCamera
- i18n.js
- QuadraticBezierCurve
- JsonElement
- PolyhedronGeometry
- PlayersLayer
- Layers
- RigExporter
- ServerLog
- AltBiomeGL
- ForestMap
- check.mjs
- .Observe
- ChatRelay
- bench.mjs
- Demisters
- Weather
- MistGL
- net.js
- SmoothZoom
- shapes.js
- .parse
- Light
- MeshCache
- Kind
- VideoTexture
- WebGLCubeRenderTarget
- FogMask
- CubicBezierCurve
- Cat
- Preview
- fetchTerrarium
- bi
- Armor
- Diet
- IEnumerator
- MuninConfig
- EllipseCurve
- Material
- parseUniform
- WebMap.Tests.csproj
- WebMap.csproj
- GLTFMaterialsDispersionExtension
- Spherical
- render
- BuildHistory
- CylinderGeometry
- TextureDecoder
- Cylindrical
- GLBufferAttribute
- QuadraticBezierCurve3
- MultiDrawRenderList
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- Fog
- FogExp2
- CurvePath
- WebGLMaterials
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- portrait.js
- EventDispatcher
- addShape
- CompressedTexture
- Third-party notices
- system
- .load
- InstancedBufferGeometry
- TextureUtils
- Rgba32
- testserver.sh
- Chart
- Shape
- Uniform
- LocationTerrain
- SerializedFile
- _points
- StaticFilesTests
- WebP
- Window
- .constructor
- worldkeys.js
- WorldEvents
- .edgeNormals

## God Nodes (most connected - your core abstractions)
1. `Vector3` - 114 edges
2. `Vector2` - 89 edges
3. `get()` - 88 edges
4. `MapDataServer` - 78 edges
5. `View3D` - 75 edges
6. `Markers` - 73 edges
7. `Object3D` - 70 edges
8. `JsonWriter` - 69 edges
9. `BufferGeometry` - 69 edges
10. `Vector4` - 66 edges

## Surprising Connections (you probably didn't know these)
- `What a regression would do on the live server, worst first` --references--> `Auth`  [INFERRED]
  TESTING.md → WebMap/Auth.cs
- `What a regression would do on the live server, worst first` --references--> `Chart`  [INFERRED]
  TESTING.md → WebMap/Chart.cs
- `What a regression would do on the live server, worst first` --references--> `Features`  [INFERRED]
  TESTING.md → WebMap/Features.cs
- `What a regression would do on the live server, worst first` --references--> `ForestMap`  [INFERRED]
  TESTING.md → WebMap/ForestMap.cs
- `What a regression would do on the live server, worst first` --references--> `Pieces`  [INFERRED]
  TESTING.md → WebMap/Pieces.cs

## Import Cycles
- None detected.

## Communities (231 total, 77 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (234): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+226 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (67): ColorManagement, DefaultLoadingManager, InterpolationSamplingMode, InterpolationSamplingType, MOUSE, TimestampQuery, TOUCH, UniformsUtils (+59 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (39): AxesHelper, Box3Helper, buildPlane(), BufferGeometry, CameraHelper, addLine(), addPoint(), CapsuleGeometry (+31 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (71): MapCore, chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM (+63 more)

### Community 4 - ".subVectors"
Cohesion: 0.04
Nodes (12): a(), c(), handleTriangle(), handleVertex(), isUniqueEdge(), Line3, LineCurve, Plane (+4 more)

### Community 5 - "WebXRController"
Cohesion: 0.09
Nodes (4): Group, Scene, UniformsGroup, WebXRController

### Community 6 - "Vector3"
Cohesion: 0.03
Nodes (16): onQuaternionChange(), onRotationChange(), applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs() (+8 more)

### Community 7 - "Object3D"
Cohesion: 0.03
Nodes (19): Bone, BoxGeometry, Camera, CubeCamera, DirectionalLight, DirectionalLightHelper, DirectionalLightShadow, Line (+11 more)

### Community 8 - "Vector3"
Cohesion: 0.10
Nodes (7): Dungeons, Signature, Inside, Visited, Kind, Runestones, Stone

### Community 9 - "ui.js"
Cohesion: 0.04
Nodes (79): iconSvg(), byName(), escape(), makeIcon(), activityHtml(), ARMOR_SLOTS, at(), BIOME_COL (+71 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (16): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+8 more)

### Community 12 - "Vegetation"
Cohesion: 0.13
Nodes (7): Class, Crunched, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.06
Nodes (18): MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel(), onPointerDown() (+10 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.05
Nodes (7): BufferAttribute, copyAttributeData(), createColorManagement(), DataUtils, denormalize(), Float16BufferAttribute, InterleavedBufferAttribute

### Community 17 - "BatchedMesh"
Cohesion: 0.04
Nodes (13): ascIdSort(), BatchedMesh, convertBufferAttribute(), CatmullRomCurve3, cloneUniformsGroups(), copyArrayContents(), flattenJSON(), InstancedBufferAttribute (+5 more)

### Community 18 - "Markers"
Cohesion: 0.05
Nodes (14): BaseOverride, BedSpot, Findable, Markers, Json, Rev, PartTimer, Portal (+6 more)

### Community 19 - "markers.js"
Cohesion: 0.08
Nodes (23): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), collator, dungeonHtml() (+15 more)

### Community 20 - "Dictionary"
Cohesion: 0.08
Nodes (16): Libraries, PrefabsJson, Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted (+8 more)

### Community 21 - ".start"
Cohesion: 0.08
Nodes (13): App, BiomeHover, fromLatLng(), toLatLng(), esc(), ForgeCard, T(), weatherWord() (+5 more)

### Community 22 - "get"
Cohesion: 0.09
Nodes (66): createElementNS(), setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), WebGLCapabilities(), getMaxAnisotropy(), textureFormatReadable() (+58 more)

### Community 23 - "Stats"
Cohesion: 0.09
Nodes (7): Boss, D, Kit, Spot, Standing, Stats, StatsTests

### Community 24 - "update"
Cohesion: 0.06
Nodes (53): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+45 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.12
Nodes (9): MapFog, Revision, ParticleSystem, ThreeDTests, Chunk, Obj, Rock, WorldObjects (+1 more)

### Community 29 - "measure.js"
Cohesion: 0.09
Nodes (14): BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool, MINUTES, reachBands() (+6 more)

### Community 31 - "Features"
Cohesion: 0.10
Nodes (5): Testing, Feature, Features, Grids, Named

### Community 32 - "ForgeCanvas"
Cohesion: 0.06
Nodes (15): Tour, prefabs, DeathsLayer, fogUsers, ForgeCanvas, loadFog(), MC, walkedFn() (+7 more)

### Community 33 - "Audio"
Cohesion: 0.05
Nodes (4): Audio, AudioAnalyser, Controls, PositionalAudio

### Community 34 - "Material"
Cohesion: 0.06
Nodes (10): LineDashedMaterial, Material, MeshDepthMaterial, MeshDistanceMaterial, MeshMatcapMaterial, MeshNormalMaterial, MeshToonMaterial, PointsMaterial (+2 more)

### Community 35 - "Gear"
Cohesion: 0.10
Nodes (9): Gear, Hit, Backstab, Magic, Melee, Ranged, Item, Peak (+1 more)

### Community 36 - "activity.js"
Cohesion: 0.08
Nodes (17): ActivityLayers, colorRgb(), fmtAgo(), fmtClock(), fmtSpan(), gridOverlay(), HEAT, hslRgb() (+9 more)

### Community 37 - "Func"
Cohesion: 0.19
Nodes (3): Entry, Given, Settings

### Community 38 - ".constructor"
Cohesion: 0.11
Nodes (27): createCanvasElement(), dispose(), update(), disposeTexture(), getUniforms(), deallocateMaterial(), getProgram(), getTargetPixelRatio() (+19 more)

### Community 43 - ".Sweep"
Cohesion: 0.06
Nodes (13): Entry, Graves, Entry, Last, Portals, Entry, Traders, Entry (+5 more)

### Community 44 - "leaflet.js"
Cohesion: 0.06
Nodes (40): Ae(), at(), be(), Ci(), De(), ei(), F(), G() (+32 more)

### Community 45 - "WebXRManager"
Cohesion: 0.06
Nodes (12): PlaneGeometry, WebGLAnimation(), onAnimationFrame(), onAnimationFrame(), WebXRDepthSensing, WebXRManager, onInputSourcesChange(), onSessionEnd() (+4 more)

### Community 46 - ".applyMatrix4"
Cohesion: 0.04
Nodes (10): Box2, BoxHelper, checkGeometryIntersection(), checkIntersection(), checkIntersection$1(), Frustum, FrustumArray, Sphere (+2 more)

### Community 49 - "Pieces"
Cohesion: 0.22
Nodes (4): Entry, Kind, Pieces, PiecesTests

### Community 50 - ".equals"
Cohesion: 0.07
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebXRManager"
Cohesion: 0.08
Nodes (14): WebGLRenderTarget, _createRenderTarget(), getMaxPrecision(), getChannel(), getParameters(), WebGLRenderer, renderObject(), renderObjects() (+6 more)

### Community 52 - "Vector4"
Cohesion: 0.03
Nodes (5): LightShadow, PointLight, PointLightShadow, SpotLightShadow, Vector4

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "net.js"
Cohesion: 0.06
Nodes (11): ChunkStore, ObjectStore, parseVeg(), RegionLoader, VegStore, FogLayer, RuinsLayer, RuinStore (+3 more)

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "Euler"
Cohesion: 0.12
Nodes (3): Euler, MeshLambertMaterial, MeshPhongMaterial

### Community 58 - "Color"
Cohesion: 0.08
Nodes (4): Color, hue2rgb(), LinearToSRGB(), SRGBToLinear()

### Community 61 - "GateTests"
Cohesion: 0.06
Nodes (8): WebMapConfig, HeightMaxZoom, HdMaps, HdMapsTests, Sink, LightModeTests, WithDir, ZoneSystemLoadPatch

### Community 62 - "TileStore"
Cohesion: 0.09
Nodes (9): Job, Job, TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered (+1 more)

### Community 63 - "markercanvas.js"
Cohesion: 0.13
Nodes (6): asDot(), countBadge(), labelImage(), labelWidth(), MarkerCanvas, MarkerGL

### Community 65 - "push"
Cohesion: 0.08
Nodes (31): renderTarget(), ExternalTexture, shadowCastingAndTexturingLightsFirst(), WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights(), setup() (+23 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.11
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Func"
Cohesion: 0.14
Nodes (6): Body, Discord, Token, DiscordRef, Result, DiscordTests

### Community 70 - "TileJob"
Cohesion: 0.13
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 72 - "PMREMGenerator"
Cohesion: 0.14
Nodes (12): ShaderMaterial, _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial(), PMREMGenerator, _setViewport(), WebGLCubeUVMaps() (+4 more)

### Community 73 - "Loader"
Cohesion: 0.05
Nodes (24): AnimationLoader, AudioLoader, handleError(), BufferGeometryLoader, getArrayBuffer(), getInterleavedBuffer(), CompressedTextureLoader, loadTexture() (+16 more)

### Community 75 - "web/js/sky.js"
Cohesion: 0.10
Nodes (10): DARK, DAY, DUSK, GROUND, HAZE, lerp(), Lighting, NIGHT (+2 more)

### Community 76 - "RigBuilder"
Cohesion: 0.14
Nodes (12): HD, bakeSkin(), hdFor(), JOINT_ORDER, loadHd(), MR_METAL, MR_ROUGH, paintOf() (+4 more)

### Community 77 - ".constructor"
Cohesion: 0.07
Nodes (7): GLTFLoader, GLTFMaterialsBumpExtension, GLTFMaterialsEmissiveStrengthExtension, GLTFMaterialsIorExtension, GLTFMaterialsIridescenceExtension, GLTFMeshGpuInstancing, GLTFMeshoptCompression

### Community 78 - "KeyframeTrack"
Cohesion: 0.09
Nodes (7): BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, LinearInterpolant, QuaternionKeyframeTrack, StringKeyframeTrack, VectorKeyframeTrack

### Community 79 - "Items"
Cohesion: 0.14
Nodes (3): Items, Ready, ItemsTests

### Community 80 - "MapDataServer"
Cohesion: 0.09
Nodes (3): MapDataServer, PlayersWs, WebSocketHandler

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "TextureExtractor"
Cohesion: 0.14
Nodes (6): At, Source, TextureExtractor, LastFound, LastReport, Running

### Community 83 - "WebMap"
Cohesion: 0.07
Nodes (9): DiscordWebHook, MapMessage, Ping, WebMap, ZNetPatchDisconnect, ZNetPatchSetServer, ZNetPatchStart, ZoneSystemPatch (+1 more)

### Community 84 - "ChunkShapes"
Cohesion: 0.03
Nodes (12): BuildingsGL, ChunkShapes, compile(), drawPicture(), PackedRegions, RECT_LAYOUT(), RuinsGL, screenArea() (+4 more)

### Community 86 - "BundleFile"
Cohesion: 0.16
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 87 - "ItemIcons"
Cohesion: 0.15
Nodes (7): 2.12.0, Entry, ItemIcons, Dir, Entry, MapIcons, Dir

### Community 88 - "HashSet"
Cohesion: 0.10
Nodes (12): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running (+4 more)

### Community 89 - "SerializedFile"
Cohesion: 0.16
Nodes (8): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode, TypeInfo

### Community 90 - "GLTFParser"
Cohesion: 0.20
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.19
Nodes (3): FeaturesTests, Grid, Cell

### Community 94 - "GlbWriter"
Cohesion: 0.15
Nodes (7): GlbWriter, Count, Primitive, Result, GlbWriter, Count, Primitive

### Community 95 - "Activity"
Cohesion: 0.24
Nodes (4): Activity, Snap, Trail, ActivityTests

### Community 96 - "web/js/view3d.js"
Cohesion: 0.12
Nodes (11): lookKey(), _ahead, AROUND, bigFromAfar(), facing(), fallbackColor(), IDENTITY, KEYS (+3 more)

### Community 97 - "WebGLState"
Cohesion: 0.30
Nodes (15): WebGLState(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), setBlending(), setCullFace(), setFlipSided() (+7 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.15
Nodes (21): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+13 more)

### Community 99 - "BundleFile"
Cohesion: 0.16
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "ModelStore"
Cohesion: 0.09
Nodes (14): Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted, PrefabsJson, QueueLength (+6 more)

### Community 104 - "TerrainPatches"
Cohesion: 0.12
Nodes (6): Heights, KeepSamples, Served, Patch, TerrainPatches, Count

### Community 105 - "Using the map"
Cohesion: 0.10
Nodes (20): Chat commands, Checking the viewer against a live server, Coming from WebMap, Configuration, Discord, Features, Full-quality textures (optional), Install (+12 more)

### Community 106 - "List"
Cohesion: 0.36
Nodes (3): Peak, Peaks, All

### Community 108 - "Part"
Cohesion: 0.22
Nodes (3): Node, Skin, Part

### Community 109 - "RaidLayer"
Cohesion: 0.21
Nodes (4): ago(), areaCache, areaImage(), RaidLayer

### Community 110 - ".FromSerialized"
Cohesion: 0.23
Nodes (3): Decoded, MeshDecoder, MeshData

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.19
Nodes (4): Gear, GroundGL, perSide(), span()

### Community 113 - "Texture"
Cohesion: 0.05
Nodes (12): CanvasTexture, CubeTexture, Data3DTexture, DataArrayTexture, DepthTexture, FramebufferTexture, RenderTarget, RenderTarget3D (+4 more)

### Community 114 - "Changelog"
Cohesion: 0.10
Nodes (19): 2.11.0, 2.13.0, 2.14.0, 2.15.0, 2.16.0, 2.7.1 and earlier, 2.8.0, 2.9.0 (+11 more)

### Community 116 - "MeshDecoder"
Cohesion: 0.28
Nodes (3): Decoded, MeshDecoder, P

### Community 117 - "Structures"
Cohesion: 0.05
Nodes (21): ChunkCache, Line, Regions, Chunk, Ruins, IndexJson, LastChanged, Total (+13 more)

### Community 118 - "arraysEqual"
Cohesion: 0.21
Nodes (19): allocTexUnits(), arraysEqual(), copyArray(), setValueM2(), setValueM3(), setValueM4(), setValueT1Array(), setValueT2DArrayArray() (+11 more)

### Community 119 - ".LookJson"
Cohesion: 0.22
Nodes (5): Item, Joints, Look, Rig, RigTests

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 122 - "Dictionary"
Cohesion: 0.17
Nodes (5): Ev, Feed, Keep, RecentJson, JsonParser

### Community 124 - "Interpolant"
Cohesion: 0.18
Nodes (3): CubicInterpolant, DiscreteInterpolant, Interpolant

### Community 125 - "InterleavedBuffer"
Cohesion: 0.14
Nodes (3): generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer

### Community 126 - ".Encode"
Cohesion: 0.19
Nodes (6): Format, Gray16, Gray8, RGB, RGBA, Png

### Community 127 - "ContourGL"
Cohesion: 0.05
Nodes (10): ContourGL, labelImage(), span(), BiomeGL, FogGL, glyphAtlas(), GuideGL, rgb() (+2 more)

### Community 128 - ".load"
Cohesion: 0.14
Nodes (5): getImageURIMimeType(), GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension, LoaderUtils

### Community 129 - "AnimationClip"
Cohesion: 0.15
Nodes (3): AnimationClip, AnimationUtils, NumberKeyframeTrack

### Community 131 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 132 - "Fact"
Cohesion: 0.08
Nodes (7): FeedTests, PinsTests, File_, PreviewTests, SettingsTests, TilesTests, VersionTests

### Community 133 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - "m"
Cohesion: 0.22
Nodes (13): d(), e(), hi(), i(), m(), Mi(), Qe(), ve() (+5 more)

### Community 138 - "Français"
Cohesion: 0.12
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 139 - "Kitchen"
Cohesion: 0.06
Nodes (23): Deeds, DeedsGonePatch, Kind, Kill, Rock, Tree, Last, Kind (+15 more)

### Community 141 - "i18n.js"
Cohesion: 0.17
Nodes (8): 2.16.1, fill(), has(), name(), num(), t(), tn(), translateTree()

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 146 - "Layers"
Cohesion: 0.06
Nodes (9): 2.9.1, AudioContext, AudioListener, Clock, ImageUtils, intersect(), Layers, serializeImage() (+1 more)

### Community 148 - "ServerLog"
Cohesion: 0.11
Nodes (6): 2.10.0, ImageConv, Line, ServerLog, Trails, ZNetPatchShutdown

### Community 150 - "ForestMap"
Cohesion: 0.09
Nodes (11): Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump, Tree (+3 more)

### Community 151 - "check.mjs"
Cohesion: 0.32
Nodes (11): [BASE, PORT, OUT], check(), map(), open(), plan(), players(), portals(), sleep() (+3 more)

### Community 152 - ".Observe"
Cohesion: 0.23
Nodes (5): What a regression would do on the live server, worst first, DeathWatch, DeedsRoutePatch, ZRoutedRpcPatch, ZRoutedRpcRoutePatch

### Community 153 - "ChatRelay"
Cohesion: 0.15
Nodes (6): Announce, Token, Pending, ChatRelay, DiscordMessage, ChatRelayTests

### Community 154 - "bench.mjs"
Cohesion: 0.24
Nodes (9): [BASE, PORT], errors, ev(), ms(), pending, send(), tab, views (+1 more)

### Community 159 - "SmoothZoom"
Cohesion: 0.36
Nodes (3): SmoothZoom, SmoothZoomControl, update()

### Community 160 - "shapes.js"
Cohesion: 0.06
Nodes (39): ALIAS, colors, glyphs, materialColors, materialNames, badgeCache, gamePinImage(), iconCache (+31 more)

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 162 - "Light"
Cohesion: 0.11
Nodes (5): AmbientLight, HemisphereLight, Light, LightProbe, RectAreaLight

### Community 163 - "MeshCache"
Cohesion: 0.24
Nodes (4): Data, MeshCache, Data, MeshCache

### Community 164 - "Kind"
Cohesion: 0.25
Nodes (8): Kind, Chest, Gate, Generator, Mining, Monster, None, Pickable

### Community 166 - "WebGLCubeRenderTarget"
Cohesion: 0.33
Nodes (5): WebGLCubeRenderTarget, WebGLCubeMaps(), get(), mapTextureMapping(), onTextureDispose()

### Community 168 - "CubicBezierCurve"
Cohesion: 0.12
Nodes (7): CubicBezier(), CubicBezierCurve, CubicBezierCurve3, CubicBezierP0(), CubicBezierP1(), CubicBezierP2(), CubicBezierP3()

### Community 169 - "Cat"
Cohesion: 0.29
Nodes (7): Cat, Bush, Other, Piece, Rock, Skip, Tree

### Community 171 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 172 - "bi"
Cohesion: 0.33
Nodes (6): ForgeMap 1.2.0, bi(), Pi(), q(), Ti(), u()

### Community 173 - "Armor"
Cohesion: 0.33
Nodes (6): Armor, Heavy, Light, Mage, Medium, None

### Community 174 - "Diet"
Cohesion: 0.33
Nodes (6): Diet, Balanced, Eitr, Hearty, None, Quick

### Community 175 - "IEnumerator"
Cohesion: 0.18
Nodes (4): SkipToMorningPatch, WorldEvents, InvasionsPath, StatePath

### Community 176 - "MuninConfig"
Cohesion: 0.22
Nodes (8): MuninConfig, DEBUG, ENABLE_3D, EXPORT_MODELS, EXTRACT_MESHES, MODEL_EXPORT_MS_PER_FRAME, TEXTURE_MAX_SIZE, USE_TEXTURES

### Community 178 - "Material"
Cohesion: 0.12
Nodes (16): Material, Ashwood, BlackMarble, Cloth, CoreWood, Crystal, DarkWood, Fire (+8 more)

### Community 179 - "parseUniform"
Cohesion: 0.17
Nodes (7): addUniform(), getPureArraySetter(), getSingularSetter(), parseUniform(), PureArrayUniform, SingleUniform, StructuredUniform

### Community 180 - "WebMap.Tests.csproj"
Cohesion: 0.29
Nodes (5): net10.0, Microsoft.NET.Test.Sdk (17.14.1), xunit (2.9.3), xunit.runner.visualstudio (3.1.4), Microsoft.NET.Sdk

### Community 181 - "WebMap.csproj"
Cohesion: 0.29
Nodes (6): net48, ILRepack.Lib.MSBuild.Task (2.0.44.2), Krafs.Publicizer (2.2.1), Microsoft.NETFramework.ReferenceAssemblies (1.0.3), SixLabors.ImageSharp (2.1.13), Microsoft.NET.Sdk

### Community 184 - "render"
Cohesion: 0.43
Nodes (4): load(), message(), render(), Spot

### Community 185 - "BuildHistory"
Cohesion: 0.15
Nodes (5): HotspotsTests, BuildHistory, Snap, Hotspots, Json

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 197 - "WebGLMaterials"
Cohesion: 0.16
Nodes (23): cloneUniforms(), getUnlitUniformColorSpace(), mergeUniforms(), WebGLBackground(), addToRenderList(), getBackground(), render(), setClear() (+15 more)

### Community 200 - "portrait.js"
Cohesion: 0.15
Nodes (13): PlayerCard, PlayerCard, bodyTexture(), curlNoise(), finish(), image(), info(), lib() (+5 more)

### Community 201 - "EventDispatcher"
Cohesion: 0.07
Nodes (8): EventDispatcher, handleVisibilityChange(), ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), LoadingManager, Timer

### Community 202 - "addShape"
Cohesion: 0.27
Nodes (11): addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3(), f4(), getBevelVec() (+3 more)

### Community 203 - "CompressedTexture"
Cohesion: 0.25
Nodes (3): CompressedArrayTexture, CompressedCubeTexture, CompressedTexture

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 205 - "system"
Cohesion: 0.11
Nodes (3): WebMap.Models.Unity, WebMap.MuninModels, WebMap.MuninModels.Unity

### Community 211 - "Chart"
Cohesion: 0.15
Nodes (5): Chart, MaskedRev, Fnv, StaticCoroutine, StaticCoroutineRunner

### Community 214 - "LocationTerrain"
Cohesion: 0.15
Nodes (5): LocationTerrain, Count, Mod, Patch, Placed

### Community 215 - "SerializedFile"
Cohesion: 0.20
Nodes (5): LeReader, ObjectInfo, SerializedFile, Texture2D, TypeNode

### Community 232 - ".constructor"
Cohesion: 0.14
Nodes (5): ArrowHelper, Mesh, MeshBasicMaterial, PointLightHelper, SphereGeometry

### Community 236 - "WorldEvents"
Cohesion: 0.33
Nodes (3): Live, Stats, WorldEvents

## Knowledge Gaps
- **246 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+241 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1979 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **77 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `.Observe` to `.update`, `TerrainPatches`, `EventDispatcher`, `Kitchen`, `.Sweep`, `i18n.js`, `MapDataServer`, `Pieces`, `Chart`, `ServerLog`, `WebMap`, `ForestMap`, `Stats`, `ChatRelay`, `WorldObjects`, `.Verify`, `Features`?**
  _High betweenness centrality (0.377) - this node is a cross-community bridge._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _246 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007323173719089244 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `EventDispatcher` to `.Observe`, `three.core.js`, `three.module.js`?**
  _High betweenness centrality (0.319) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.00799937667194764 - nodes in this community are weakly interconnected._
- **Why does `View3D` connect `View3D` to `web/js/view3d.js`, `.edgeNormals`, `web/js/sky.js`, `.update`?**
  _High betweenness centrality (0.069) - this node is a cross-community bridge._
- **Should `.push` be split into smaller, more focused modules?**
  _Cohesion score 0.03231000429368828 - nodes in this community are weakly interconnected._