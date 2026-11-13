# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 232 files · ~735,008 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6993 nodes · 17020 edges · 230 communities (160 shown, 70 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 869 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `f9214633`
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
- .Sweep
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
- BuildingsGL
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
- Pieces
- PrefabExporter
- JsonWriter
- Vehicles
- leaflet.js
- WebXRManager
- .applyMatrix4
- Fact
- AuthTests
- .build
- .equals
- WebGLRenderer
- Vector4
- Veg
- net.js
- PropertyBinding
- Feed
- Matrix4
- Color
- Quaternion
- Box3
- .ReadConfigFile
- TileStore
- markercanvas.js
- Fog
- push
- GLTFLoader.js
- InlineData
- Func
- AnimationAction
- TileJob
- Curve
- PMREMGenerator
- Loader
- ShapesCanvas
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
- Matrix3
- Box2
- WithDir
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
- addToRenderList
- PropertyMixer
- What a regression would do on the live server, worst first
- RaidLayer
- .FromSerialized
- Hand
- GroundGL
- Texture
- BiomeGL
- VegPartGL
- MeshDecoder
- Structures
- arraysEqual
- Euler
- map-core.test.mjs
- Locations
- Dictionary
- GuideGL
- Interpolant
- InterleavedBuffer
- TileMath
- ContourGL
- .load
- AnimationClip
- GateTests
- particles.js
- .Verify
- MigrationTests
- LocationTerrain
- TextureDecoder
- BufferGeometryUtils.js
- Runestones
- Français
- Kitchen
- PerspectiveCamera
- Changelog
- .clamp
- JsonElement
- PolyhedronGeometry
- PlayersLayer
- Clock
- ZNetPeer
- ServerLog
- AltBiomeGL
- ForestMap
- check.mjs
- .LookJson
- i18n.js
- bench.mjs
- FogLayer
- Weather
- MistGL
- net.js
- SmoothZoom
- vegpack.js
- .parse
- Light
- MeshCache
- m
- CubicBezierCurve
- WebGLShaderCache
- FogMask
- ChatRelay
- Cat
- Preview
- fetchTerrarium
- bi
- parseUniform
- Timer
- IEnumerator
- MuninConfig
- VideoTexture
- Material
- Rgba32
- WebMap.Tests.csproj
- WebMap.csproj
- .canopyMaterial
- StructuresLayer
- render
- MeshPhysicalMaterial
- Portals
- TextureDecoder
- Cylindrical
- GLBufferAttribute
- Kind
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- EllipseCurve
- WorldEvents
- WebGLMaterials
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- portrait.js
- EventDispatcher
- .clone
- QuadraticBezierCurve
- Third-party notices
- system
- .load
- QuadraticBezierCurve3
- WebGLCubeRenderTarget
- GLTFMaterialsDispersionExtension
- testserver.sh
- Chart
- FogExp2
- Uniform
- Setup
- SerializedFile
- MultiDrawRenderList
- WebP
- Window
- Line
- worldkeys.js

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

## Communities (230 total, 70 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (234): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+226 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (69): _cache, ColorManagement, InterpolationSamplingMode, InterpolationSamplingType, MathUtils, MOUSE, TOUCH, UniformsUtils (+61 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (41): AxesHelper, buildPlane(), BufferGeometry, CameraHelper, addLine(), addPoint(), CapsuleGeometry, CircleGeometry (+33 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (98): chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM, TILE (+90 more)

### Community 4 - ".subVectors"
Cohesion: 0.05
Nodes (12): a(), c(), handleTriangle(), handleVertex(), checkGeometryIntersection(), checkIntersection$1(), isUniqueEdge(), Plane (+4 more)

### Community 5 - "WebXRController"
Cohesion: 0.10
Nodes (3): Group, UniformsGroup, WebXRController

### Community 6 - "Vector3"
Cohesion: 0.03
Nodes (12): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+4 more)

### Community 7 - "Object3D"
Cohesion: 0.04
Nodes (7): Camera, CubeCamera, DirectionalLightShadow, Object3D, OrthographicCamera, SpotLightHelper, SpotLightShadow

### Community 8 - ".Sweep"
Cohesion: 0.07
Nodes (10): Entry, Graves, Demisters, Dungeons, Signature, Inside, Visited, Placed (+2 more)

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (56): escape(), statsHtml(), BIOME_SVG, breakable(), BUILD_SVG, BUSH_SVG, busyChart(), CONTOUR_SVG (+48 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (17): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), tame(), farSkip() (+9 more)

### Community 12 - "Vegetation"
Cohesion: 0.14
Nodes (5): Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.06
Nodes (18): MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel(), onPointerDown() (+10 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.04
Nodes (8): BufferAttribute, convertBufferAttribute(), copyAttributeData(), DataUtils, denormalize(), Float16BufferAttribute, InterleavedBufferAttribute, sortedArray()

### Community 17 - "BatchedMesh"
Cohesion: 0.06
Nodes (7): ascIdSort(), BatchedMesh, copyArrayContents(), DirectionalLightHelper, flattenJSON(), InstancedBufferAttribute, TextureUtils

### Community 18 - "Markers"
Cohesion: 0.06
Nodes (12): BaseOverride, BedSpot, Findable, Markers, Json, Rev, PartTimer, Portal (+4 more)

### Community 19 - "markers.js"
Cohesion: 0.07
Nodes (26): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), byName(), collator (+18 more)

### Community 20 - "Dictionary"
Cohesion: 0.08
Nodes (17): Fnv, Libraries, PrefabsJson, Info, ModelStore, Exported, Hashes, MeshesPresent (+9 more)

### Community 21 - ".start"
Cohesion: 0.08
Nodes (8): App, BiomeHover, fromLatLng(), esc(), ForgeCard, T(), weatherWord(), windWord()

### Community 22 - "get"
Cohesion: 0.09
Nodes (68): createCanvasElement(), createElementNS(), setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), WebGLCapabilities(), getMaxAnisotropy() (+60 more)

### Community 23 - "Stats"
Cohesion: 0.09
Nodes (7): Boss, D, Kit, Spot, Standing, Stats, StatsTests

### Community 24 - "update"
Cohesion: 0.05
Nodes (59): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+51 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.11
Nodes (9): MapFog, Revision, ParticleSystem, ThreeDTests, Chunk, Obj, Rock, WorldObjects (+1 more)

### Community 27 - "BuildingsGL"
Cohesion: 0.08
Nodes (7): BuildingsGL, hexRgb(), materialRgb(), PackedRegions, packRects(), RECT_LAYOUT(), RuinsGL

### Community 29 - "measure.js"
Cohesion: 0.06
Nodes (12): FogGL, rgb(), WorldEdgeGL, fmtDist(), fmtMin(), fmtTime(), MeasureTool, reachBands() (+4 more)

### Community 31 - "Features"
Cohesion: 0.10
Nodes (5): Testing, Feature, Features, Grids, Named

### Community 32 - "ForgeCanvas"
Cohesion: 0.06
Nodes (14): Tour, DeathsLayer, fogUsers, ForgeCanvas, loadFog(), MC, walkedFn(), PathsLayer (+6 more)

### Community 33 - "Audio"
Cohesion: 0.05
Nodes (4): Audio, AudioAnalyser, Controls, PositionalAudio

### Community 34 - "Material"
Cohesion: 0.06
Nodes (10): LineDashedMaterial, Material, MeshDepthMaterial, MeshDistanceMaterial, MeshMatcapMaterial, MeshNormalMaterial, MeshToonMaterial, PointsMaterial (+2 more)

### Community 35 - "Gear"
Cohesion: 0.08
Nodes (20): Armor, Heavy, Light, Mage, Medium, None, Diet, Balanced (+12 more)

### Community 36 - "activity.js"
Cohesion: 0.08
Nodes (17): ActivityLayers, colorRgb(), fmtAgo(), fmtClock(), fmtSpan(), gridOverlay(), HEAT, hslRgb() (+9 more)

### Community 37 - "Func"
Cohesion: 0.19
Nodes (3): Entry, Given, Settings

### Community 38 - ".constructor"
Cohesion: 0.14
Nodes (21): refreshFogUniforms(), update(), disposeTexture(), dispose(), getUniforms(), deallocateMaterial(), getProgram(), getUniformList() (+13 more)

### Community 40 - "Pieces"
Cohesion: 0.22
Nodes (4): Entry, Kind, Pieces, PiecesTests

### Community 41 - "PrefabExporter"
Cohesion: 0.05
Nodes (16): GlbWriter, Count, Node, Primitive, Skin, PrefabExporter, Result, Joints (+8 more)

### Community 43 - "Vehicles"
Cohesion: 0.11
Nodes (8): Entry, Traders, Entry, Kind, Boat, Cart, None, Vehicles

### Community 44 - "leaflet.js"
Cohesion: 0.06
Nodes (37): Ae(), be(), De(), ei(), F(), G(), h(), i() (+29 more)

### Community 45 - "WebXRManager"
Cohesion: 0.06
Nodes (14): renderTarget(), ExternalTexture, WebGLAnimation(), onAnimationFrame(), onAnimationFrame(), WebXRDepthSensing, WebXRManager, onAnimationFrame() (+6 more)

### Community 46 - ".applyMatrix4"
Cohesion: 0.04
Nodes (9): checkIntersection(), Frustum, FrustumArray, InstancedMesh, LOD, _points, SkinnedMesh, Sphere (+1 more)

### Community 47 - "Fact"
Cohesion: 0.11
Nodes (5): GearTests, SettingsTests, StaticFilesTests, TilesTests, VersionTests

### Community 49 - ".build"
Cohesion: 0.23
Nodes (3): drawPicture(), ShapeCache, vegShowMask()

### Community 50 - ".equals"
Cohesion: 0.09
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebGLRenderer"
Cohesion: 0.09
Nodes (10): WebGLRenderTarget, _createRenderTarget(), getMaxPrecision(), getChannel(), getParameters(), WebGLRenderer, renderObject(), renderObjects() (+2 more)

### Community 52 - "Vector4"
Cohesion: 0.04
Nodes (3): LightShadow, PointLightShadow, Vector4

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "net.js"
Cohesion: 0.12
Nodes (5): ChunkStore, parseVeg(), RegionLoader, RuinsLayer, RuinStore

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "Feed"
Cohesion: 0.23
Nodes (5): Ev, Feed, Keep, RecentJson, FeedTests

### Community 57 - "Matrix4"
Cohesion: 0.04
Nodes (5): AudioListener, Bone, Matrix2, Matrix4, Skeleton

### Community 58 - "Color"
Cohesion: 0.08
Nodes (5): Color, createColorManagement(), hue2rgb(), LinearToSRGB(), SRGBToLinear()

### Community 61 - ".ReadConfigFile"
Cohesion: 0.14
Nodes (3): WebMapConfig, HeightMaxZoom, LightModeTests

### Community 62 - "TileStore"
Cohesion: 0.12
Nodes (7): TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered, RenderMsTotal

### Community 63 - "markercanvas.js"
Cohesion: 0.10
Nodes (13): colors, asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache (+5 more)

### Community 65 - "push"
Cohesion: 0.08
Nodes (29): shadowCastingAndTexturingLightsFirst(), ShadowUniformsCache(), UniformsCache(), WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights(), setup() (+21 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.11
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Func"
Cohesion: 0.13
Nodes (6): Body, Discord, Token, DiscordRef, Result, DiscordTests

### Community 70 - "TileJob"
Cohesion: 0.12
Nodes (10): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+2 more)

### Community 71 - "Curve"
Cohesion: 0.06
Nodes (5): CatmullRomCurve3, Curve, LineCurve, LineCurve3, SplineCurve

### Community 72 - "PMREMGenerator"
Cohesion: 0.14
Nodes (11): ShaderMaterial, _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial(), PMREMGenerator, _setViewport(), WebGLCubeUVMaps() (+3 more)

### Community 73 - "Loader"
Cohesion: 0.05
Nodes (22): AnimationLoader, AudioLoader, BufferGeometryLoader, CompressedTextureLoader, loadTexture(), CubeTextureLoader, loadTexture(), DataTexture (+14 more)

### Community 75 - "web/js/sky.js"
Cohesion: 0.10
Nodes (10): DARK, DAY, DUSK, GROUND, HAZE, lerp(), Lighting, NIGHT (+2 more)

### Community 76 - "RigBuilder"
Cohesion: 0.14
Nodes (14): HD, bakeSkin(), dressMaterial(), hdFor(), JOINT_ORDER, loadHd(), lookKey(), MR_METAL (+6 more)

### Community 77 - ".constructor"
Cohesion: 0.07
Nodes (7): GLTFLoader, GLTFMaterialsBumpExtension, GLTFMaterialsEmissiveStrengthExtension, GLTFMaterialsIorExtension, GLTFMaterialsIridescenceExtension, GLTFMeshGpuInstancing, GLTFMeshoptCompression

### Community 78 - "KeyframeTrack"
Cohesion: 0.09
Nodes (7): BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, LinearInterpolant, QuaternionKeyframeTrack, StringKeyframeTrack, VectorKeyframeTrack

### Community 79 - "Items"
Cohesion: 0.15
Nodes (3): Items, Ready, ItemsTests

### Community 80 - "MapDataServer"
Cohesion: 0.08
Nodes (3): MapDataServer, PlayersWs, MapMessage

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "TextureExtractor"
Cohesion: 0.13
Nodes (6): At, Source, TextureExtractor, LastFound, LastReport, Running

### Community 83 - "WebMap"
Cohesion: 0.07
Nodes (10): Announce, Token, Pending, DiscordWebHook, StaticCoroutine, StaticCoroutineRunner, WebMap, ZNetPatchSetServer (+2 more)

### Community 86 - "BundleFile"
Cohesion: 0.16
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 87 - "ItemIcons"
Cohesion: 0.09
Nodes (13): 2.12.0, Entry, ItemIcons, Dir, Entry, MapIcons, Dir, Format (+5 more)

### Community 88 - "HashSet"
Cohesion: 0.12
Nodes (8): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running

### Community 89 - "SerializedFile"
Cohesion: 0.17
Nodes (6): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeNode

### Community 90 - "GLTFParser"
Cohesion: 0.20
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.18
Nodes (3): FeaturesTests, Grid, Cell

### Community 93 - "Box2"
Cohesion: 0.07
Nodes (5): ascSort(), Box2, Box3Helper, BoxHelper, Raycaster

### Community 94 - "WithDir"
Cohesion: 0.11
Nodes (6): HdMaps, HdMapsTests, Sink, PinsTests, File_, WithDir

### Community 95 - "Activity"
Cohesion: 0.24
Nodes (4): Activity, Snap, Trail, ActivityTests

### Community 96 - "web/js/view3d.js"
Cohesion: 0.14
Nodes (12): _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), fallbackColor(), IDENTITY (+4 more)

### Community 97 - "WebGLState"
Cohesion: 0.20
Nodes (18): WebGLState(), ColorBuffer(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), reset(), scissor() (+10 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.16
Nodes (22): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+14 more)

### Community 99 - "BundleFile"
Cohesion: 0.15
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "ModelStore"
Cohesion: 0.10
Nodes (14): Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted, PrefabsJson, QueueLength (+6 more)

### Community 104 - "TerrainPatches"
Cohesion: 0.11
Nodes (8): Heights, KeepSamples, Job, Served, Patch, TerrainPatches, Count, Job

### Community 105 - "Using the map"
Cohesion: 0.10
Nodes (20): Chat commands, Checking the viewer against a live server, Coming from WebMap, Configuration, Discord, Features, Full-quality textures (optional), Install (+12 more)

### Community 106 - "addToRenderList"
Cohesion: 0.27
Nodes (9): cloneUniforms(), getUnlitUniformColorSpace(), mergeUniforms(), WebGLBackground(), addToRenderList(), dispose(), getBackground(), render() (+1 more)

### Community 108 - "What a regression would do on the live server, worst first"
Cohesion: 0.15
Nodes (6): What a regression would do on the live server, worst first, DeathWatch, DeedsRoutePatch, WebSocketHandler, ZRoutedRpcPatch, ZRoutedRpcRoutePatch

### Community 109 - "RaidLayer"
Cohesion: 0.20
Nodes (4): MapCore, ago(), areaImage(), RaidLayer

### Community 110 - ".FromSerialized"
Cohesion: 0.22
Nodes (6): MeshExtractor, LastFound, LastReport, Running, Decoded, MeshDecoder

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.21
Nodes (4): GroundGL, perSide(), span(), screenArea()

### Community 113 - "Texture"
Cohesion: 0.04
Nodes (15): CanvasTexture, CompressedArrayTexture, CompressedCubeTexture, CompressedTexture, CubeTexture, Data3DTexture, DataArrayTexture, DepthTexture (+7 more)

### Community 114 - "BiomeGL"
Cohesion: 0.22
Nodes (3): 2.13.0, bigText(), BiomeGL

### Community 116 - "MeshDecoder"
Cohesion: 0.30
Nodes (3): Decoded, MeshDecoder, P

### Community 117 - "Structures"
Cohesion: 0.05
Nodes (22): ChunkCache, Line, Regions, Chunk, Ruins, IndexJson, LastChanged, Total (+14 more)

### Community 118 - "arraysEqual"
Cohesion: 0.21
Nodes (19): allocTexUnits(), arraysEqual(), copyArray(), setValueM2(), setValueM3(), setValueM4(), setValueT1Array(), setValueT2DArrayArray() (+11 more)

### Community 119 - "Euler"
Cohesion: 0.08
Nodes (6): Euler, MeshLambertMaterial, MeshPhongMaterial, onQuaternionChange(), onRotationChange(), Scene

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 122 - "Dictionary"
Cohesion: 0.17
Nodes (4): HotspotsTests, BuildHistory, Snap, JsonParser

### Community 123 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

### Community 124 - "Interpolant"
Cohesion: 0.14
Nodes (4): CubicInterpolant, DiscreteInterpolant, Interpolant, QuaternionLinearInterpolant

### Community 125 - "InterleavedBuffer"
Cohesion: 0.12
Nodes (3): generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer

### Community 127 - "ContourGL"
Cohesion: 0.18
Nodes (3): ContourGL, labelImage(), span()

### Community 128 - ".load"
Cohesion: 0.14
Nodes (5): getImageURIMimeType(), GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension, LoaderUtils

### Community 129 - "AnimationClip"
Cohesion: 0.15
Nodes (3): AnimationClip, AnimationUtils, NumberKeyframeTrack

### Community 131 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 133 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 134 - "LocationTerrain"
Cohesion: 0.17
Nodes (4): LocationTerrain, Count, Mod, Patch

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - "Runestones"
Cohesion: 0.16
Nodes (6): Peak, Peaks, All, Kind, Runestones, Stone

### Community 138 - "Français"
Cohesion: 0.12
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 139 - "Kitchen"
Cohesion: 0.06
Nodes (23): Deeds, DeedsGonePatch, Kind, Kill, Rock, Tree, Last, Kind (+15 more)

### Community 140 - "PerspectiveCamera"
Cohesion: 0.08
Nodes (4): ArrayCamera, Layers, PerspectiveCamera, StereoCamera

### Community 141 - "Changelog"
Cohesion: 0.09
Nodes (22): 2.10.0, 2.11.0, 2.14.0, 2.15.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0 (+14 more)

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 145 - "PlayersLayer"
Cohesion: 0.18
Nodes (6): toLatLng(), PlayersLayer, setupTour(), refresh(), takeWalked(), T()

### Community 146 - "Clock"
Cohesion: 0.19
Nodes (4): AudioContext, Clock, ImageUtils, serializeImage()

### Community 147 - "ZNetPeer"
Cohesion: 0.18
Nodes (4): Ping, ZNetPatchDisconnect, ZNetPatchStart, ZRoutedRpcAddPeerPatch

### Community 148 - "ServerLog"
Cohesion: 0.15
Nodes (4): ImageConv, Line, ServerLog, ZNetPatchShutdown

### Community 150 - "ForestMap"
Cohesion: 0.07
Nodes (12): Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump, Tree (+4 more)

### Community 151 - "check.mjs"
Cohesion: 0.32
Nodes (11): [BASE, PORT, OUT], check(), map(), open(), plan(), players(), portals(), sleep() (+3 more)

### Community 152 - ".LookJson"
Cohesion: 0.11
Nodes (6): Item, Look, Rig, RigTests, Hotspots, Json

### Community 153 - "i18n.js"
Cohesion: 0.17
Nodes (7): Gear, fill(), has(), num(), t(), tn(), translateTree()

### Community 154 - "bench.mjs"
Cohesion: 0.24
Nodes (9): [BASE, PORT], errors, ev(), ms(), pending, send(), tab, views (+1 more)

### Community 159 - "SmoothZoom"
Cohesion: 0.36
Nodes (3): SmoothZoom, SmoothZoomControl, update()

### Community 160 - "vegpack.js"
Cohesion: 0.11
Nodes (11): ObjectStore, VegStore, packTrees(), radiusOf(), RGB, seedOf(), SMALL_R, TREE_STRIDE (+3 more)

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 162 - "Light"
Cohesion: 0.07
Nodes (8): AmbientLight, DirectionalLight, HemisphereLight, Light, LightProbe, PointLight, RectAreaLight, SpotLight

### Community 163 - "MeshCache"
Cohesion: 0.22
Nodes (4): Data, MeshCache, Data, MeshCache

### Community 164 - "m"
Cohesion: 0.19
Nodes (14): at(), d(), e(), hi(), ht(), Li(), m(), Qe() (+6 more)

### Community 165 - "CubicBezierCurve"
Cohesion: 0.12
Nodes (7): CubicBezier(), CubicBezierCurve, CubicBezierCurve3, CubicBezierP0(), CubicBezierP1(), CubicBezierP2(), CubicBezierP3()

### Community 168 - "ChatRelay"
Cohesion: 0.26
Nodes (3): ChatRelay, DiscordMessage, ChatRelayTests

### Community 169 - "Cat"
Cohesion: 0.29
Nodes (7): Cat, Bush, Other, Piece, Rock, Skip, Tree

### Community 171 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 172 - "bi"
Cohesion: 0.33
Nodes (6): ForgeMap 1.2.0, bi(), Pi(), q(), Ti(), u()

### Community 173 - "parseUniform"
Cohesion: 0.17
Nodes (7): addUniform(), getPureArraySetter(), getSingularSetter(), parseUniform(), PureArrayUniform, SingleUniform, StructuredUniform

### Community 175 - "IEnumerator"
Cohesion: 0.19
Nodes (4): SkipToMorningPatch, WorldEvents, InvasionsPath, StatePath

### Community 176 - "MuninConfig"
Cohesion: 0.22
Nodes (8): MuninConfig, DEBUG, ENABLE_3D, EXPORT_MODELS, EXTRACT_MESHES, MODEL_EXPORT_MS_PER_FRAME, TEXTURE_MAX_SIZE, USE_TEXTURES

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

### Community 186 - "Portals"
Cohesion: 0.27
Nodes (3): Entry, Last, Portals

### Community 191 - "Kind"
Cohesion: 0.25
Nodes (8): Kind, Chest, Gate, Generator, Mining, Monster, None, Pickable

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 195 - "WorldEvents"
Cohesion: 0.33
Nodes (3): Live, Stats, WorldEvents

### Community 197 - "WebGLMaterials"
Cohesion: 0.33
Nodes (14): WebGLMaterials(), refreshMaterialUniforms(), refreshTransformUniform(), refreshUniformsCommon(), refreshUniformsDash(), refreshUniformsDistance(), refreshUniformsLine(), refreshUniformsMatcap() (+6 more)

### Community 200 - "portrait.js"
Cohesion: 0.08
Nodes (34): PlayerCard, getJSON(), activityHtml(), ARMOR_SLOTS, at(), BIOME_COL, clock(), connHtml() (+26 more)

### Community 201 - "EventDispatcher"
Cohesion: 0.08
Nodes (14): 2.9.1, handleError(), getArrayBuffer(), getInterleavedBuffer(), EventDispatcher, getTypedArray(), ImageBitmapLoader, onImageError() (+6 more)

### Community 202 - ".clone"
Cohesion: 0.05
Nodes (17): cloneUniformsGroups(), CurvePath, addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3() (+9 more)

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 205 - "system"
Cohesion: 0.11
Nodes (4): WebMap.Models.Unity, WebMap.MuninModels, WebMap.MuninModels.Unity, WebMap.Models

### Community 208 - "WebGLCubeRenderTarget"
Cohesion: 0.40
Nodes (4): WebGLCubeRenderTarget, WebGLCubeMaps(), get(), mapTextureMapping()

### Community 215 - "SerializedFile"
Cohesion: 0.16
Nodes (8): TypeInfo, LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode

### Community 232 - "Line"
Cohesion: 0.07
Nodes (10): ArrowHelper, BoxGeometry, ConeGeometry, CylinderGeometry, Line, Mesh, MeshBasicMaterial, PlaneHelper (+2 more)

## Knowledge Gaps
- **246 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+241 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1979 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **70 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `What a regression would do on the live server, worst first` to `.Verify`, `Func`, `ChatRelay`, `Pieces`, `Portals`, `Kitchen`, `TerrainPatches`, `Changelog`, `Timer`, `MapDataServer`, `Chart`, `WebMap`, `ForestMap`, `Stats`, `WorldObjects`, `View3D`, `Features`?**
  _High betweenness centrality (0.379) - this node is a cross-community bridge._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _246 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007323173719089244 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `Timer` to `three.core.js`, `EventDispatcher`, `What a regression would do on the live server, worst first`, `three.module.js`?**
  _High betweenness centrality (0.319) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007905439755973563 - nodes in this community are weakly interconnected._
- **Why does `View3D` connect `View3D` to `web/js/view3d.js`, `web/js/sky.js`, `.canopyMaterial`?**
  _High betweenness centrality (0.072) - this node is a cross-community bridge._
- **Should `.push` be split into smaller, more focused modules?**
  _Cohesion score 0.030703826169107228 - nodes in this community are weakly interconnected._