# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 232 files · ~734,879 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6992 nodes · 17018 edges · 227 communities (168 shown, 59 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 869 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `c38a2040`
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
- .parseObject
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
- Mesh
- Structures
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
- Part
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
- WebGLProgram
- ContourGL
- .load
- AnimationClip
- .Struck
- particles.js
- Heights
- MigrationTests
- Deeds
- TextureDecoder
- BufferGeometryUtils.js
- Runestones
- Français
- Kitchen
- PerspectiveCamera
- Changelog
- GlbWriter
- JsonElement
- PolyhedronGeometry
- PlayersLayer
- Clock
- .Encode
- ServerLog
- AltBiomeGL
- ForestMap
- check.mjs
- Rig
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
- k
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
- oi
- WebMap.Tests.csproj
- WebMap.csproj
- d
- LineCurve
- render
- Texture2D
- .load
- TextureDecoder
- Cylindrical
- GLBufferAttribute
- SplineCurve
- Made
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- Type
- ArrayCamera
- CubicPoly
- WebGLMaterials
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- portrait.js
- EventDispatcher
- CurvePath
- getKeyframeOrder
- Third-party notices
- system
- .load
- probeAsync
- TextureUtils
- RawShaderMaterial
- testserver.sh
- Chart
- WebGLShaderStage
- Uniform
- SerializedFile
- StaticFilesTests
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

## Communities (227 total, 59 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (216): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+208 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (40): _cache, ColorManagement, InterpolationSamplingType, TimestampQuery, TOUCH, UniformsUtils, arrayCacheF32, arrayCacheI32 (+32 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (45): AxesHelper, Box3Helper, buildPlane(), BoxHelper, BufferGeometry, CameraHelper, addLine(), addPoint() (+37 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (87): BiomeHover, chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM (+79 more)

### Community 4 - ".subVectors"
Cohesion: 0.04
Nodes (14): a(), c(), x(), handleTriangle(), handleVertex(), checkGeometryIntersection(), checkIntersection$1(), scalePt2() (+6 more)

### Community 5 - "WebXRController"
Cohesion: 0.08
Nodes (4): EventDispatcher, Group, UniformsGroup, WebXRController

### Community 6 - "Vector3"
Cohesion: 0.03
Nodes (15): onRotationChange(), applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex() (+7 more)

### Community 7 - "Object3D"
Cohesion: 0.04
Nodes (7): CubeCamera, DirectionalLight, DirectionalLightShadow, FrustumArray, Object3D, onQuaternionChange(), Sprite

### Community 8 - ".Sweep"
Cohesion: 0.09
Nodes (13): Dungeons, Signature, Inside, Visited, Kind, Chest, Gate, Generator (+5 more)

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (56): escape(), statsHtml(), BIOME_SVG, breakable(), BUILD_SVG, BUSH_SVG, busyChart(), CONTOUR_SVG (+48 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (16): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+8 more)

### Community 12 - "Vegetation"
Cohesion: 0.18
Nodes (6): Class, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.06
Nodes (18): MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel(), onPointerDown() (+10 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.04
Nodes (13): BufferAttribute, copyAttributeData(), DataUtils, denormalize(), Float16BufferAttribute, Int16BufferAttribute, Int32BufferAttribute, Int8BufferAttribute (+5 more)

### Community 17 - "BatchedMesh"
Cohesion: 0.04
Nodes (13): ascIdSort(), BatchedMesh, Bone, CatmullRomCurve3, checkIntersection(), copyArrayContents(), flattenJSON(), InstancedBufferAttribute (+5 more)

### Community 18 - "Markers"
Cohesion: 0.06
Nodes (13): BaseOverride, BedSpot, Findable, Markers, Json, Rev, PartTimer, Portal (+5 more)

### Community 19 - "markers.js"
Cohesion: 0.07
Nodes (25): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), byName(), collator (+17 more)

### Community 20 - "Dictionary"
Cohesion: 0.08
Nodes (16): Libraries, PrefabsJson, Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted (+8 more)

### Community 21 - ".start"
Cohesion: 0.09
Nodes (7): App, fromLatLng(), esc(), ForgeCard, T(), weatherWord(), windWord()

### Community 22 - "get"
Cohesion: 0.08
Nodes (69): createCanvasElement(), createElementNS(), setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), WebGLCapabilities(), getMaxAnisotropy() (+61 more)

### Community 23 - "Stats"
Cohesion: 0.09
Nodes (8): What a regression would do on the live server, worst first, Boss, D, Kit, Spot, Standing, Stats, StatsTests

### Community 24 - "update"
Cohesion: 0.06
Nodes (53): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+45 more)

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
Nodes (17): FogGL, rgb(), WorldEdgeGL, BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime() (+9 more)

### Community 31 - "Features"
Cohesion: 0.10
Nodes (5): Feature, Features, Grids, Named, Fnv

### Community 32 - "ForgeCanvas"
Cohesion: 0.06
Nodes (16): Tour, prefabs, DeathsLayer, fogUsers, ForgeCanvas, loadFog(), MC, walkedFn() (+8 more)

### Community 33 - "Audio"
Cohesion: 0.05
Nodes (3): Audio, AudioAnalyser, PositionalAudio

### Community 34 - "Material"
Cohesion: 0.05
Nodes (12): LineDashedMaterial, Material, MeshDepthMaterial, MeshDistanceMaterial, MeshMatcapMaterial, MeshNormalMaterial, MeshPhysicalMaterial, MeshStandardMaterial (+4 more)

### Community 35 - "Gear"
Cohesion: 0.09
Nodes (20): Armor, Heavy, Light, Mage, Medium, None, Diet, Balanced (+12 more)

### Community 36 - "activity.js"
Cohesion: 0.08
Nodes (17): ActivityLayers, colorRgb(), fmtAgo(), fmtClock(), fmtSpan(), gridOverlay(), HEAT, hslRgb() (+9 more)

### Community 37 - "Func"
Cohesion: 0.11
Nodes (6): Entry, Given, Settings, Live, Stats, WorldEvents

### Community 38 - ".constructor"
Cohesion: 0.11
Nodes (27): refreshFogUniforms(), WebGLMorphtargets(), update(), disposeTexture(), getUniforms(), getContext(), getProgram(), getUniformList() (+19 more)

### Community 40 - "Pieces"
Cohesion: 0.10
Nodes (7): HdMaps, Entry, Kind, Pieces, HdMapsTests, Sink, PiecesTests

### Community 41 - "PrefabExporter"
Cohesion: 0.09
Nodes (3): PrefabExporter, PrefabExporter, Result

### Community 43 - "Vehicles"
Cohesion: 0.11
Nodes (8): Entry, Traders, Entry, Kind, Boat, Cart, None, Vehicles

### Community 44 - "leaflet.js"
Cohesion: 0.07
Nodes (16): Ae(), Ci(), ei(), Ie(), ii(), Jt(), l(), Le() (+8 more)

### Community 45 - "WebXRManager"
Cohesion: 0.06
Nodes (14): renderTarget(), ExternalTexture, WebGLAnimation(), onAnimationFrame(), onAnimationFrame(), WebXRDepthSensing, WebXRManager, onAnimationFrame() (+6 more)

### Community 46 - ".applyMatrix4"
Cohesion: 0.04
Nodes (6): ascSort(), Box2, Frustum, LOD, Raycaster, Sphere

### Community 47 - "Fact"
Cohesion: 0.08
Nodes (6): GateTests, GearTests, PinsTests, File_, SettingsTests, VersionTests

### Community 48 - "AuthTests"
Cohesion: 0.15
Nodes (3): Auth, Session, AuthTests

### Community 50 - ".equals"
Cohesion: 0.08
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebGLRenderer"
Cohesion: 0.09
Nodes (12): WebGLRenderTarget, _createRenderTarget(), getMaxPrecision(), getChannel(), getParameters(), WebGLRenderer, renderObject(), renderObjects() (+4 more)

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "net.js"
Cohesion: 0.07
Nodes (8): ChunkStore, ObjectStore, parseVeg(), RegionLoader, VegStore, RuinsLayer, RuinStore, getBuffer()

### Community 55 - "PropertyBinding"
Cohesion: 0.07
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "Feed"
Cohesion: 0.23
Nodes (5): Ev, Feed, Keep, RecentJson, FeedTests

### Community 57 - "Matrix4"
Cohesion: 0.07
Nodes (11): addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3(), f4(), getBevelVec() (+3 more)

### Community 58 - "Color"
Cohesion: 0.07
Nodes (8): Color, createColorManagement(), damp(), euclideanModulo(), hue2rgb(), LinearToSRGB(), pingpong(), SRGBToLinear()

### Community 59 - "Quaternion"
Cohesion: 0.09
Nodes (3): 2.13.0, makeClipAdditive(), Quaternion

### Community 61 - ".ReadConfigFile"
Cohesion: 0.12
Nodes (4): WebMapConfig, HeightMaxZoom, LightModeTests, ZoneSystemLoadPatch

### Community 62 - "TileStore"
Cohesion: 0.08
Nodes (9): TileMath, ChunksPerSide, TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered (+1 more)

### Community 63 - "markercanvas.js"
Cohesion: 0.10
Nodes (13): colors, asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache (+5 more)

### Community 64 - ".parseObject"
Cohesion: 0.07
Nodes (11): DataTexture, Fog, FogExp2, getTrackTypeForValueTypeName(), LightProbe, LineLoop, MaterialLoader, ObjectLoader (+3 more)

### Community 65 - "push"
Cohesion: 0.10
Nodes (24): shadowCastingAndTexturingLightsFirst(), ShadowUniformsCache(), UniformsCache(), WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights(), setup() (+16 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.10
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Func"
Cohesion: 0.08
Nodes (12): Body, ChatRelay, Discord, Token, DiscordMessage, DiscordRef, Result, ChatRelayTests (+4 more)

### Community 70 - "TileJob"
Cohesion: 0.12
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 71 - "Curve"
Cohesion: 0.07
Nodes (9): ArcCurve, Curve, EllipseCurve, QuadraticBezier(), QuadraticBezierCurve, QuadraticBezierCurve3, QuadraticBezierP0(), QuadraticBezierP1() (+1 more)

### Community 72 - "PMREMGenerator"
Cohesion: 0.13
Nodes (12): cloneUniformsGroups(), ShaderMaterial, _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial(), PMREMGenerator, _setViewport() (+4 more)

### Community 73 - "Loader"
Cohesion: 0.10
Nodes (12): AnimationLoader, AudioLoader, BufferGeometryLoader, CompressedTextureLoader, loadTexture(), CubeTextureLoader, loadTexture(), DataTextureLoader (+4 more)

### Community 75 - "web/js/sky.js"
Cohesion: 0.10
Nodes (10): DARK, DAY, DUSK, GROUND, HAZE, lerp(), Lighting, NIGHT (+2 more)

### Community 76 - "RigBuilder"
Cohesion: 0.11
Nodes (18): 2.15.0, HTTP endpoints, HD, look(), bakeSkin(), dressMaterial(), hdFor(), JOINT_ORDER (+10 more)

### Community 77 - ".constructor"
Cohesion: 0.07
Nodes (7): GLTFLoader, GLTFMaterialsClearcoatExtension, GLTFMaterialsDispersionExtension, GLTFMaterialsEmissiveStrengthExtension, GLTFMaterialsIorExtension, GLTFMeshGpuInstancing, GLTFMeshoptCompression

### Community 78 - "KeyframeTrack"
Cohesion: 0.11
Nodes (6): BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, QuaternionKeyframeTrack, StringKeyframeTrack, VectorKeyframeTrack

### Community 79 - "Items"
Cohesion: 0.11
Nodes (4): Items, Ready, ItemsTests, WithDir

### Community 80 - "MapDataServer"
Cohesion: 0.05
Nodes (5): MapDataServer, PlayersWs, MapMessage, WebSocketHandler, Trails

### Community 81 - ".assignTexture"
Cohesion: 0.06
Nodes (8): GLTFMaterialsAnisotropyExtension, GLTFMaterialsBumpExtension, GLTFMaterialsIridescenceExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "TextureExtractor"
Cohesion: 0.13
Nodes (6): At, Source, TextureExtractor, LastFound, LastReport, Running

### Community 83 - "WebMap"
Cohesion: 0.11
Nodes (4): DiscordWebHook, WebMap, ZNetPatchSetServer, ZoneSystemPatch

### Community 86 - "BundleFile"
Cohesion: 0.16
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 87 - "ItemIcons"
Cohesion: 0.15
Nodes (7): 2.12.0, Entry, ItemIcons, Dir, Entry, MapIcons, Dir

### Community 88 - "HashSet"
Cohesion: 0.12
Nodes (8): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running

### Community 89 - "SerializedFile"
Cohesion: 0.17
Nodes (6): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeNode

### Community 90 - "GLTFParser"
Cohesion: 0.19
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.15
Nodes (4): FeaturesTests, Grid, Cell, J

### Community 93 - "Mesh"
Cohesion: 0.09
Nodes (4): Camera, Mesh, OrthographicCamera, SkinnedMesh

### Community 94 - "Structures"
Cohesion: 0.10
Nodes (11): Base, Chunk, Piece, Shape, Structures, Builders, IndexJson, LastChanged (+3 more)

### Community 95 - "Activity"
Cohesion: 0.10
Nodes (10): Activity, Snap, Trail, Announce, Token, Pending, DeathWatch, ActivityTests (+2 more)

### Community 96 - "web/js/view3d.js"
Cohesion: 0.11
Nodes (14): _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), facing(), fallbackColor() (+6 more)

### Community 97 - "WebGLState"
Cohesion: 0.23
Nodes (16): WebGLState(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), reset(), scissor(), setBlending() (+8 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.13
Nodes (22): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+14 more)

### Community 99 - "BundleFile"
Cohesion: 0.15
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "ModelStore"
Cohesion: 0.09
Nodes (14): Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted, PrefabsJson, QueueLength (+6 more)

### Community 102 - "Path"
Cohesion: 0.10
Nodes (4): Path, Shape, ShapePath, toShapesNoHoles()

### Community 104 - "TerrainPatches"
Cohesion: 0.11
Nodes (7): Patch, TerrainPatches, Count, LocationTerrain, Count, Mod, Patch

### Community 105 - "Using the map"
Cohesion: 0.11
Nodes (18): Chat commands, Checking the viewer against a live server, Configuration, Discord, Features, Full-quality textures (optional), Licence and credit, Local test server (+10 more)

### Community 106 - "addToRenderList"
Cohesion: 0.16
Nodes (15): cloneUniforms(), getUnlitUniformColorSpace(), mergeUniforms(), WebGLBackground(), addToRenderList(), dispose(), getBackground(), render() (+7 more)

### Community 108 - "Part"
Cohesion: 0.17
Nodes (5): Node, Skin, Part, Player, RigExporter

### Community 109 - "RaidLayer"
Cohesion: 0.18
Nodes (5): MapCore, ago(), areaCache, areaImage(), RaidLayer

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

### Community 116 - "MeshDecoder"
Cohesion: 0.30
Nodes (3): Decoded, MeshDecoder, P

### Community 117 - "Structures"
Cohesion: 0.07
Nodes (12): ChunkCache, Line, Regions, Chunk, Ruins, IndexJson, LastChanged, Total (+4 more)

### Community 118 - "arraysEqual"
Cohesion: 0.21
Nodes (19): allocTexUnits(), arraysEqual(), copyArray(), setValueM2(), setValueM3(), setValueM4(), setValueT1Array(), setValueT2DArrayArray() (+11 more)

### Community 119 - "Euler"
Cohesion: 0.09
Nodes (6): Euler, MeshBasicMaterial, MeshLambertMaterial, MeshPhongMaterial, PointLightHelper, Scene

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 122 - "Dictionary"
Cohesion: 0.13
Nodes (6): HotspotsTests, BuildHistory, Snap, Hotspots, Json, JsonParser

### Community 123 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

### Community 124 - "Interpolant"
Cohesion: 0.13
Nodes (5): CubicInterpolant, DiscreteInterpolant, Interpolant, LinearInterpolant, QuaternionLinearInterpolant

### Community 125 - "InterleavedBuffer"
Cohesion: 0.08
Nodes (7): getArrayBuffer(), getInterleavedBuffer(), generateUUID(), getTypedArray(), InstancedBufferGeometry, InstancedInterleavedBuffer, InterleavedBuffer

### Community 126 - "WebGLProgram"
Cohesion: 0.08
Nodes (25): fetchAttributeLocations(), filterEmptyLine(), generateCubeUVSize(), generateDefines(), generateEnvMapBlendingDefine(), generateEnvMapModeDefine(), generateEnvMapTypeDefine(), generatePrecision() (+17 more)

### Community 127 - "ContourGL"
Cohesion: 0.18
Nodes (3): ContourGL, labelImage(), span()

### Community 128 - ".load"
Cohesion: 0.20
Nodes (3): GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension

### Community 129 - "AnimationClip"
Cohesion: 0.11
Nodes (6): Coming from WebMap, Install, AnimationClip, AnimationUtils, NumberKeyframeTrack, subclip()

### Community 131 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 132 - "Heights"
Cohesion: 0.18
Nodes (5): Heights, KeepSamples, Job, Served, Job

### Community 133 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 134 - "Deeds"
Cohesion: 0.22
Nodes (7): Deeds, Kind, Kill, Rock, Tree, Last, DeedsTests

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - "Runestones"
Cohesion: 0.17
Nodes (4): Kind, Kind, Runestones, Stone

### Community 138 - "Français"
Cohesion: 0.12
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 139 - "Kitchen"
Cohesion: 0.13
Nodes (4): DeedsRoutePatch, Kitchen, Station, KitchenTests

### Community 140 - "PerspectiveCamera"
Cohesion: 0.05
Nodes (6): Layers, LightShadow, PerspectiveCamera, PointLightShadow, SpotLightShadow, StereoCamera

### Community 141 - "Changelog"
Cohesion: 0.12
Nodes (15): 2.11.0, 2.14.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog (+7 more)

### Community 142 - "GlbWriter"
Cohesion: 0.15
Nodes (7): GlbWriter, Count, Primitive, Result, GlbWriter, Count, Primitive

### Community 143 - "JsonElement"
Cohesion: 0.19
Nodes (5): Testing, Entry, Last, Portals, PortalsTests

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 145 - "PlayersLayer"
Cohesion: 0.16
Nodes (8): toLatLng(), iconSvg(), PALETTE, PlayersLayer, setupTour(), refresh(), takeWalked(), T()

### Community 146 - "Clock"
Cohesion: 0.12
Nodes (5): AudioContext, AudioListener, Clock, ImageUtils, serializeImage()

### Community 147 - ".Encode"
Cohesion: 0.20
Nodes (6): Format, Gray16, Gray8, RGB, RGBA, Png

### Community 148 - "ServerLog"
Cohesion: 0.22
Nodes (3): Line, ServerLog, ZNetPatchShutdown

### Community 150 - "ForestMap"
Cohesion: 0.06
Nodes (13): Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump, Tree (+5 more)

### Community 151 - "check.mjs"
Cohesion: 0.32
Nodes (11): [BASE, PORT, OUT], check(), map(), open(), plan(), players(), portals(), sleep() (+3 more)

### Community 152 - "Rig"
Cohesion: 0.24
Nodes (5): Item, Joints, Look, Rig, RigTests

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
Cohesion: 0.23
Nodes (10): packTrees(), radiusOf(), RGB, seedOf(), SMALL_R, TREE_STRIDE, unpackRegion(), VEG (+2 more)

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 162 - "Light"
Cohesion: 0.09
Nodes (6): AmbientLight, HemisphereLight, Light, PointLight, RectAreaLight, SpotLight

### Community 163 - "MeshCache"
Cohesion: 0.23
Nodes (4): Data, MeshCache, Data, MeshCache

### Community 164 - "m"
Cohesion: 0.23
Nodes (12): be(), De(), e(), hi(), m(), p(), pe(), Qe() (+4 more)

### Community 165 - "CubicBezierCurve"
Cohesion: 0.12
Nodes (7): CubicBezier(), CubicBezierCurve, CubicBezierCurve3, CubicBezierP0(), CubicBezierP1(), CubicBezierP2(), CubicBezierP3()

### Community 166 - "WebGLShaderCache"
Cohesion: 0.17
Nodes (5): WebGLCubeRenderTarget, WebGLCubeMaps(), get(), mapTextureMapping(), WebGLShaderCache

### Community 167 - "FogMask"
Cohesion: 0.12
Nodes (4): TilesTests, FogMask, Kept, WorldPicture

### Community 168 - "k"
Cohesion: 0.24
Nodes (12): F(), G(), h(), j(), k(), ke(), ne(), e() (+4 more)

### Community 169 - "Cat"
Cohesion: 0.29
Nodes (7): Cat, Bush, Other, Piece, Rock, Skip, Tree

### Community 171 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 172 - "bi"
Cohesion: 0.40
Nodes (5): ForgeMap 1.2.0, bi(), Pi(), Ti(), u()

### Community 173 - "parseUniform"
Cohesion: 0.17
Nodes (7): addUniform(), getPureArraySetter(), getSingularSetter(), parseUniform(), PureArrayUniform, SingleUniform, StructuredUniform

### Community 175 - "IEnumerator"
Cohesion: 0.12
Nodes (7): ZNetPatchDisconnect, ZNetPatchStart, ZRoutedRpcAddPeerPatch, SkipToMorningPatch, WorldEvents, InvasionsPath, StatePath

### Community 176 - "MuninConfig"
Cohesion: 0.22
Nodes (8): MuninConfig, DEBUG, ENABLE_3D, EXPORT_MODELS, EXTRACT_MESHES, MODEL_EXPORT_MS_PER_FRAME, TEXTURE_MAX_SIZE, USE_TEXTURES

### Community 178 - "Material"
Cohesion: 0.12
Nodes (16): Material, Ashwood, BlackMarble, Cloth, CoreWood, Crystal, DarkWood, Fire (+8 more)

### Community 179 - "oi"
Cohesion: 0.67
Nodes (4): Je(), ni(), oi(), si()

### Community 180 - "WebMap.Tests.csproj"
Cohesion: 0.29
Nodes (5): net10.0, Microsoft.NET.Test.Sdk (17.14.1), xunit (2.9.3), xunit.runner.visualstudio (3.1.4), Microsoft.NET.Sdk

### Community 181 - "WebMap.csproj"
Cohesion: 0.29
Nodes (6): net48, ILRepack.Lib.MSBuild.Task (2.0.44.2), Krafs.Publicizer (2.2.1), Microsoft.NETFramework.ReferenceAssemblies (1.0.3), SixLabors.ImageSharp (2.1.13), Microsoft.NET.Sdk

### Community 182 - "d"
Cohesion: 0.25
Nodes (9): at(), d(), ht(), i(), Li(), Mi(), v(), W() (+1 more)

### Community 184 - "render"
Cohesion: 0.43
Nodes (4): load(), message(), render(), Spot

### Community 191 - "Made"
Cohesion: 0.33
Nodes (6): Made, Brewed, Burnt, Cooked, Honey, Smelted

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 194 - "Type"
Cohesion: 0.40
Nodes (5): Type, Brew, Cook, Hive, Smelt

### Community 197 - "WebGLMaterials"
Cohesion: 0.33
Nodes (14): WebGLMaterials(), refreshMaterialUniforms(), refreshTransformUniform(), refreshUniformsCommon(), refreshUniformsDash(), refreshUniformsDistance(), refreshUniformsLine(), refreshUniformsMatcap() (+6 more)

### Community 200 - "portrait.js"
Cohesion: 0.08
Nodes (35): PlayerCard, stats, getJSON(), activityHtml(), ARMOR_SLOTS, at(), BIOME_COL, clock() (+27 more)

### Community 201 - "EventDispatcher"
Cohesion: 0.11
Nodes (10): 2.9.1, handleError(), ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), intersect(), LoadingManager (+2 more)

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 205 - "system"
Cohesion: 0.14
Nodes (4): WebMap.Models.Unity, WebMap.MuninModels, WebMap.MuninModels.Unity, WebMap.Models

### Community 211 - "Chart"
Cohesion: 0.18
Nodes (4): Chart, MaskedRev, StaticCoroutine, StaticCoroutineRunner

### Community 215 - "SerializedFile"
Cohesion: 0.16
Nodes (8): TypeInfo, LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode

### Community 223 - "Window"
Cohesion: 0.27
Nodes (3): Ping, Window, PingTests

### Community 232 - "Line"
Cohesion: 0.06
Nodes (11): ArrowHelper, BoxGeometry, convertBufferAttribute(), ConeGeometry, Controls, CylinderGeometry, DirectionalLightHelper, Line (+3 more)

## Knowledge Gaps
- **246 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+241 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1979 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **59 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `.Struck`, `Func`, `Deeds`, `Pieces`, `TerrainPatches`, `Kitchen`, `Changelog`, `View3D`, `JsonElement`, `AuthTests`, `MapDataServer`, `Timer`, `Chart`, `WebMap`, `ForestMap`, `WorldObjects`, `Features`, `Activity`?**
  _High betweenness centrality (0.379) - this node is a cross-community bridge._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _246 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.008097165991902834 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `Timer` to `three.core.js`, `three.module.js`, `WebXRController`, `Stats`?**
  _High betweenness centrality (0.319) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.00819277108433735 - nodes in this community are weakly interconnected._
- **Why does `View3D` connect `View3D` to `web/js/view3d.js`, `web/js/sky.js`?**
  _High betweenness centrality (0.071) - this node is a cross-community bridge._
- **Should `.push` be split into smaller, more focused modules?**
  _Cohesion score 0.028296753128967893 - nodes in this community are weakly interconnected._