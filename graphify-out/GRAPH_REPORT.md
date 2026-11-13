# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 230 files · ~731,634 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6925 nodes · 16885 edges · 227 communities (153 shown, 74 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 876 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `4789749e`
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
- HashSet
- ui.js
- Part
- View3D
- Vegetation
- OrbitControls
- BufferAttribute
- xunit
- Deeds
- BatchedMesh
- Markers
- markers.js
- Dictionary
- .start
- WebMap.cs
- Stats
- update
- textures-hd.py
- WorldObjects
- has
- View3D
- measure.js
- system_collections_generic
- Features
- ForgeCanvas
- Audio
- Material
- Gear
- activity.js
- TileMath
- .constructor
- Vector2
- GlbWriter
- Kitchen
- JsonWriter
- Kind
- leaflet.js
- WebXRManager
- .applyMatrix4
- Vector3
- AuthTests
- Line
- .equals
- WebXRManager
- Vector4
- Veg
- net.js
- PropertyBinding
- system
- PositionalAudio
- Color
- Quaternion
- Box3
- GateTests
- TileStore
- markercanvas.js
- WithDir
- push
- GLTFLoader.js
- InlineData
- Func
- AnimationAction
- TileJob
- Curve
- PMREMGenerator
- .parseObject
- Matrix3
- web/js/sky.js
- RigBuilder
- .constructor
- KeyframeTrack
- Items
- MapDataServer
- .assignTexture
- TextureExtractor
- LoadingManager
- ChunkShapes
- AnimationMixer
- BundleFile
- TreesGL
- HashSet
- SerializedFile
- GLTFParser
- Fact
- ShapesCanvas
- BuildingsGL
- Pieces
- Activity
- web/js/view3d.js
- get
- WebGLBindingStates
- BundleFile
- package.json
- ModelStore
- Path
- BiomeMap
- TerrainPatches
- Using the map
- Regex
- PropertyMixer
- PrefabExporter
- RaidLayer
- .FromSerialized
- Hand
- GroundGL
- Texture
- Changelog
- Feed
- TerrainPatches
- Structures
- arraysEqual
- .LookJson
- map-core.test.mjs
- Locations
- Dictionary
- Interpolant
- Transform
- Vehicles
- ContourGL
- .load
- AnimationClip
- .Export
- particles.js
- Fact
- MigrationTests
- TilesTests
- TextureDecoder
- BufferGeometryUtils.js
- Light
- Français
- .Encode
- PerspectiveCamera
- i18n.js
- QuadraticBezierCurve
- Portals
- PolyhedronGeometry
- PlayersLayer
- Clock
- AudioListener
- WebMap
- AltBiomeGL
- CompressedTexture
- check.mjs
- BuildingsGL
- .load
- bench.mjs
- TextureDecoder
- .canopyMaterial
- MistGL
- FallbackTileLayer
- SmoothZoom
- vegpack.js
- .parse
- CurvePath
- ZNetPeer
- bi
- VideoTexture
- MeshDecoder
- FogMask
- CubicBezierCurve3
- BiomeGL
- Preview
- fetchTerrarium
- GuideGL
- ServerLog
- m
- IEnumerator
- MuninConfig
- EllipseCurve
- Material
- QuadraticBezierCurve3
- WebMap.Tests.csproj
- WebMap.csproj
- Shape
- Spherical
- render
- createColorManagement
- FogGL
- Cylindrical
- GLBufferAttribute
- FogLayer
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- k
- StructuresLayer
- CubicBezierCurve
- addShape
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- playercard.js
- Timer
- Weather
- Third-party notices
- system_io
- .load
- Peaks
- TextureUtils
- testserver.sh
- MultiDrawRenderList
- Uniform
- layers.js
- SerializedFile
- d
- WebGLCubeRenderTarget
- WebP
- .NewWorld
- worldkeys.js
- .rebuild
- Fog
- FogExp2

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

## Communities (227 total, 74 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (240): _addedEvent, _alignedPosition, ArrayCamera, _axis, _basePosition, _batchIntersects, _boneMatrix, _box (+232 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (75): _cache, DefaultLoadingManager, InterpolationSamplingMode, InterpolationSamplingType, MathUtils, MOUSE, TimestampQuery, TOUCH (+67 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (39): Box3Helper, buildPlane(), BufferGeometry, CameraHelper, addLine(), addPoint(), CapsuleGeometry, CircleGeometry (+31 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (90): chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM, TILE (+82 more)

### Community 4 - ".subVectors"
Cohesion: 0.04
Nodes (11): a(), c(), handleTriangle(), checkGeometryIntersection(), isUniqueEdge(), Line3, Plane, Ray (+3 more)

### Community 5 - "WebXRController"
Cohesion: 0.06
Nodes (8): convertBufferAttribute(), Controls, copyArrayContents(), EventDispatcher, Group, sortedArray(), UniformsGroup, WebXRController

### Community 6 - "Vector3"
Cohesion: 0.03
Nodes (14): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+6 more)

### Community 7 - "Object3D"
Cohesion: 0.02
Nodes (13): Camera, CubeCamera, DirectionalLight, DirectionalLightHelper, DirectionalLightShadow, HemisphereLightHelper, LOD, Matrix4 (+5 more)

### Community 8 - "HashSet"
Cohesion: 0.05
Nodes (16): Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump, Tree (+8 more)

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (52): escape(), BIOME_SVG, breakable(), BUILD_SVG, BUSH_SVG, busyChart(), CONTOUR_SVG, DAYS (+44 more)

### Community 10 - "Part"
Cohesion: 0.25
Nodes (3): Node, Skin, Part

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (13): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), makeLabel() (+5 more)

### Community 12 - "Vegetation"
Cohesion: 0.10
Nodes (7): Class, Crunched, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.06
Nodes (18): MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel(), onPointerDown() (+10 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.05
Nodes (7): BufferAttribute, handleVertex(), copyAttributeData(), DataUtils, denormalize(), Float16BufferAttribute, InterleavedBufferAttribute

### Community 16 - "Deeds"
Cohesion: 0.15
Nodes (8): Deeds, DeedsGonePatch, Kind, Kill, Rock, Tree, Last, DeedsTests

### Community 17 - "BatchedMesh"
Cohesion: 0.04
Nodes (11): ascIdSort(), AxesHelper, BatchedMesh, Bone, CatmullRomCurve3, DataTexture, flattenJSON(), InstancedBufferAttribute (+3 more)

### Community 18 - "Markers"
Cohesion: 0.07
Nodes (11): BaseOverride, BedSpot, Findable, Markers, Json, Rev, PartTimer, Portal (+3 more)

### Community 19 - "markers.js"
Cohesion: 0.07
Nodes (25): markers, adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), byName() (+17 more)

### Community 20 - "Dictionary"
Cohesion: 0.08
Nodes (16): Libraries, PrefabsJson, Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted (+8 more)

### Community 21 - ".start"
Cohesion: 0.09
Nodes (9): App, BiomeHover, fromLatLng(), toLatLng(), esc(), ForgeCard, T(), weatherWord() (+1 more)

### Community 22 - "WebMap.cs"
Cohesion: 0.16
Nodes (6): Announce, Token, Pending, DeathWatch, ZRoutedRpcPatch, ZRoutedRpcRoutePatch

### Community 23 - "Stats"
Cohesion: 0.11
Nodes (7): What a regression would do on the live server, worst first, Boss, D, Kit, Spot, Standing, Stats

### Community 24 - "update"
Cohesion: 0.06
Nodes (51): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+43 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.08
Nodes (17): MapFog, Revision, ParticleSystem, ThreeDTests, TablePin, Cat, Bush, Other (+9 more)

### Community 27 - "has"
Cohesion: 0.14
Nodes (12): WebGLCapabilities(), getMaxAnisotropy(), getMaxPrecision(), textureFormatReadable(), textureTypeReadable(), getChannel(), getParameters(), has() (+4 more)

### Community 29 - "measure.js"
Cohesion: 0.06
Nodes (16): rgb(), WorldEdgeGL, BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool (+8 more)

### Community 31 - "Features"
Cohesion: 0.08
Nodes (8): Testing, Chart, MaskedRev, Feature, Features, Grids, Named, Fnv

### Community 32 - "ForgeCanvas"
Cohesion: 0.06
Nodes (15): Tour, DeathsLayer, fogUsers, ForgeCanvas, loadFog(), MC, walkedFn(), PathsLayer (+7 more)

### Community 34 - "Material"
Cohesion: 0.03
Nodes (18): Euler, LineDashedMaterial, Material, MeshDepthMaterial, MeshDistanceMaterial, MeshLambertMaterial, MeshMatcapMaterial, MeshNormalMaterial (+10 more)

### Community 35 - "Gear"
Cohesion: 0.07
Nodes (21): Armor, Heavy, Light, Mage, Medium, None, Diet, Balanced (+13 more)

### Community 36 - "activity.js"
Cohesion: 0.08
Nodes (17): ActivityLayers, colorRgb(), fmtAgo(), fmtClock(), fmtSpan(), gridOverlay(), HEAT, hslRgb() (+9 more)

### Community 38 - ".constructor"
Cohesion: 0.08
Nodes (41): createCanvasElement(), WebGLCubeUVMaps(), dispose(), onTextureDispose(), WebGLMaterials(), refreshFogUniforms(), refreshMaterialUniforms(), refreshTransformUniform() (+33 more)

### Community 40 - "GlbWriter"
Cohesion: 0.14
Nodes (7): GlbWriter, Count, Primitive, Result, GlbWriter, Count, Primitive

### Community 41 - "Kitchen"
Cohesion: 0.08
Nodes (16): DeedsRoutePatch, Kind, Kitchen, Made, Brewed, Burnt, Cooked, Honey (+8 more)

### Community 43 - "Kind"
Cohesion: 0.09
Nodes (9): Kind, Runestones, Stone, Entry, Kind, Boat, Cart, None (+1 more)

### Community 44 - "leaflet.js"
Cohesion: 0.07
Nodes (21): Ae(), Ci(), ei(), Ie(), ii(), Je(), Jt(), l() (+13 more)

### Community 45 - "WebXRManager"
Cohesion: 0.06
Nodes (14): renderTarget(), ExternalTexture, WebGLAnimation(), onAnimationFrame(), onAnimationFrame(), WebXRDepthSensing, WebXRManager, onAnimationFrame() (+6 more)

### Community 46 - ".applyMatrix4"
Cohesion: 0.03
Nodes (13): ascSort(), Box2, BoxHelper, checkIntersection(), checkIntersection$1(), Frustum, FrustumArray, InstancedMesh (+5 more)

### Community 47 - "Vector3"
Cohesion: 0.10
Nodes (12): Dungeons, Signature, Inside, Visited, Kind, Chest, Gate, Generator (+4 more)

### Community 48 - "AuthTests"
Cohesion: 0.15
Nodes (3): Auth, Session, AuthTests

### Community 49 - "Line"
Cohesion: 0.10
Nodes (7): ArrowHelper, ConeGeometry, CylinderGeometry, Line, MeshBasicMaterial, PointLightHelper, SphereGeometry

### Community 50 - ".equals"
Cohesion: 0.08
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebXRManager"
Cohesion: 0.07
Nodes (27): WebGLRenderTarget, WebGLRenderer, renderObject(), renderObjects(), renderTransmissionPass(), WebGLShadowMap(), getDepthMaterial(), renderObject() (+19 more)

### Community 52 - "Vector4"
Cohesion: 0.03
Nodes (6): LightShadow, PointLight, PointLightShadow, SpotLight, SpotLightShadow, Vector4

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "net.js"
Cohesion: 0.13
Nodes (4): ChunkStore, RegionLoader, RuinsLayer, RuinStore

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "system"
Cohesion: 0.14
Nodes (3): WebMap.Models.Unity, WebMap.MuninModels.Unity, WebMap.Models

### Community 61 - "GateTests"
Cohesion: 0.08
Nodes (5): WebMapConfig, HeightMaxZoom, GateTests, LightModeTests, ZoneSystemLoadPatch

### Community 62 - "TileStore"
Cohesion: 0.11
Nodes (7): TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered, RenderMsTotal

### Community 63 - "markercanvas.js"
Cohesion: 0.10
Nodes (14): iconSvg(), asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache (+6 more)

### Community 64 - "WithDir"
Cohesion: 0.20
Nodes (4): PiecesTests, PinsTests, File_, WithDir

### Community 65 - "push"
Cohesion: 0.09
Nodes (28): WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights(), setup(), setupView(), WebGLPrograms(), acquireProgram() (+20 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.11
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Func"
Cohesion: 0.05
Nodes (15): Body, ChatRelay, Discord, Token, DiscordMessage, DiscordRef, Result, Entry (+7 more)

### Community 70 - "TileJob"
Cohesion: 0.12
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 71 - "Curve"
Cohesion: 0.09
Nodes (3): Curve, LineCurve, LineCurve3

### Community 72 - "PMREMGenerator"
Cohesion: 0.08
Nodes (22): BoxGeometry, cloneUniforms(), cloneUniformsGroups(), getUnlitUniformColorSpace(), mergeUniforms(), Mesh, ShaderMaterial, _createRenderTarget() (+14 more)

### Community 73 - ".parseObject"
Cohesion: 0.06
Nodes (22): AnimationLoader, AudioLoader, handleError(), BufferGeometryLoader, CompressedTextureLoader, loadTexture(), CubeTextureLoader, loadTexture() (+14 more)

### Community 75 - "web/js/sky.js"
Cohesion: 0.10
Nodes (10): DARK, DAY, DUSK, GROUND, HAZE, lerp(), Lighting, NIGHT (+2 more)

### Community 76 - "RigBuilder"
Cohesion: 0.14
Nodes (13): HD, bakeSkin(), hdFor(), JOINT_ORDER, loadHd(), lookKey(), MR_METAL, MR_ROUGH (+5 more)

### Community 77 - ".constructor"
Cohesion: 0.07
Nodes (7): GLTFLoader, GLTFMaterialsClearcoatExtension, GLTFMaterialsDispersionExtension, GLTFMaterialsEmissiveStrengthExtension, GLTFMaterialsIorExtension, GLTFMeshGpuInstancing, GLTFMeshoptCompression

### Community 78 - "KeyframeTrack"
Cohesion: 0.10
Nodes (9): Coming from WebMap, Install, BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, QuaternionKeyframeTrack, StringKeyframeTrack, subclip() (+1 more)

### Community 79 - "Items"
Cohesion: 0.15
Nodes (3): Items, Ready, ItemsTests

### Community 80 - "MapDataServer"
Cohesion: 0.06
Nodes (4): MapDataServer, PlayersWs, MapMessage, WebSocketHandler

### Community 81 - ".assignTexture"
Cohesion: 0.06
Nodes (8): GLTFMaterialsAnisotropyExtension, GLTFMaterialsBumpExtension, GLTFMaterialsIridescenceExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "TextureExtractor"
Cohesion: 0.13
Nodes (6): At, Source, TextureExtractor, LastFound, LastReport, Running

### Community 83 - "LoadingManager"
Cohesion: 0.08
Nodes (8): 2.9.1, ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), intersect(), Layers, LoadingManager

### Community 86 - "BundleFile"
Cohesion: 0.15
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 87 - "TreesGL"
Cohesion: 0.23
Nodes (3): drawPicture(), ShapeCache, vegShowMask()

### Community 88 - "HashSet"
Cohesion: 0.15
Nodes (8): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running

### Community 89 - "SerializedFile"
Cohesion: 0.18
Nodes (8): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode, TypeInfo

### Community 90 - "GLTFParser"
Cohesion: 0.19
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.11
Nodes (5): FeaturesTests, PortalsTests, Grid, Cell, J

### Community 93 - "BuildingsGL"
Cohesion: 0.10
Nodes (6): hexRgb(), materialRgb(), PackedRegions, packRects(), RECT_LAYOUT(), RuinsGL

### Community 94 - "Pieces"
Cohesion: 0.11
Nodes (6): HdMaps, Entry, Kind, Pieces, HdMapsTests, Sink

### Community 95 - "Activity"
Cohesion: 0.24
Nodes (4): Activity, Snap, Trail, ActivityTests

### Community 96 - "web/js/view3d.js"
Cohesion: 0.13
Nodes (13): Street, _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), fallbackColor() (+5 more)

### Community 97 - "get"
Cohesion: 0.10
Nodes (60): createElementNS(), setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), getContext(), get(), activeTexture() (+52 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.12
Nodes (23): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+15 more)

### Community 99 - "BundleFile"
Cohesion: 0.15
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "ModelStore"
Cohesion: 0.09
Nodes (14): Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted, PrefabsJson, QueueLength (+6 more)

### Community 103 - "BiomeMap"
Cohesion: 0.14
Nodes (4): BiomeMap, Label, StaticCoroutine, StaticCoroutineRunner

### Community 104 - "TerrainPatches"
Cohesion: 0.16
Nodes (5): Heights, KeepSamples, Job, Served, Job

### Community 105 - "Using the map"
Cohesion: 0.11
Nodes (18): Chat commands, Checking the viewer against a live server, Configuration, Discord, Features, Full-quality textures (optional), Licence and credit, Local test server (+10 more)

### Community 106 - "Regex"
Cohesion: 0.24
Nodes (4): Data, MeshCache, Data, MeshCache

### Community 109 - "RaidLayer"
Cohesion: 0.18
Nodes (5): MapCore, ago(), areaCache, areaImage(), RaidLayer

### Community 110 - ".FromSerialized"
Cohesion: 0.16
Nodes (7): MeshExtractor, LastFound, LastReport, Running, Decoded, MeshDecoder, P

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.21
Nodes (4): GroundGL, perSide(), span(), screenArea()

### Community 113 - "Texture"
Cohesion: 0.03
Nodes (18): getArrayBuffer(), getInterleavedBuffer(), CanvasTexture, CubeTexture, Data3DTexture, DataArrayTexture, DepthTexture, FramebufferTexture (+10 more)

### Community 114 - "Changelog"
Cohesion: 0.11
Nodes (16): 2.11.0, 2.14.0, 2.16.0, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog, ForgeMap 1.0.0 (+8 more)

### Community 115 - "Feed"
Cohesion: 0.20
Nodes (6): Ev, Feed, Keep, RecentJson, FeedTests, SkipToMorningPatch

### Community 116 - "TerrainPatches"
Cohesion: 0.10
Nodes (8): Patch, TerrainPatches, Count, LocationTerrain, Count, Mod, Patch, Placed

### Community 117 - "Structures"
Cohesion: 0.05
Nodes (22): ChunkCache, Line, Regions, Chunk, Ruins, IndexJson, LastChanged, Total (+14 more)

### Community 118 - "arraysEqual"
Cohesion: 0.21
Nodes (19): allocTexUnits(), arraysEqual(), copyArray(), setValueM2(), setValueM3(), setValueM4(), setValueT1Array(), setValueT2DArrayArray() (+11 more)

### Community 119 - ".LookJson"
Cohesion: 0.20
Nodes (5): Item, Joints, Look, Rig, RigTests

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.22
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 122 - "Dictionary"
Cohesion: 0.15
Nodes (4): HotspotsTests, BuildHistory, Snap, JsonParser

### Community 124 - "Interpolant"
Cohesion: 0.17
Nodes (4): CubicInterpolant, DiscreteInterpolant, Interpolant, LinearInterpolant

### Community 126 - "Vehicles"
Cohesion: 0.14
Nodes (7): 2.12.0, Entry, ItemIcons, Dir, Entry, MapIcons, Dir

### Community 127 - "ContourGL"
Cohesion: 0.18
Nodes (3): ContourGL, labelImage(), span()

### Community 128 - ".load"
Cohesion: 0.20
Nodes (3): GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension

### Community 129 - "AnimationClip"
Cohesion: 0.11
Nodes (5): AnimationClip, AnimationUtils, getTrackTypeForValueTypeName(), NumberKeyframeTrack, parseKeyframeTrack()

### Community 131 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 132 - "Fact"
Cohesion: 0.14
Nodes (4): SettingsTests, StaticFilesTests, StatsTests, VersionTests

### Community 133 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 134 - "TilesTests"
Cohesion: 0.21
Nodes (3): TilesTests, FogMask, Kept

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - "Light"
Cohesion: 0.11
Nodes (5): AmbientLight, HemisphereLight, Light, LightProbe, RectAreaLight

### Community 138 - "Français"
Cohesion: 0.12
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 139 - ".Encode"
Cohesion: 0.21
Nodes (6): Format, Gray16, Gray8, RGB, RGBA, Png

### Community 141 - "i18n.js"
Cohesion: 0.15
Nodes (9): 2.16.1, Gear, fill(), has(), name(), num(), t(), tn() (+1 more)

### Community 143 - "Portals"
Cohesion: 0.17
Nodes (5): Entry, Last, Portals, Entry, Traders

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 146 - "Clock"
Cohesion: 0.19
Nodes (4): AudioContext, Clock, ImageUtils, SRGBToLinear()

### Community 148 - "WebMap"
Cohesion: 0.09
Nodes (4): DiscordWebHook, WebMap, ZNetPatchSetServer, ZoneSystemPatch

### Community 150 - "CompressedTexture"
Cohesion: 0.25
Nodes (3): CompressedArrayTexture, CompressedCubeTexture, CompressedTexture

### Community 151 - "check.mjs"
Cohesion: 0.32
Nodes (11): [BASE, PORT, OUT], check(), map(), open(), plan(), players(), portals(), sleep() (+3 more)

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

### Community 163 - "ZNetPeer"
Cohesion: 0.17
Nodes (5): Ping, Window, PingTests, ZNetPatchDisconnect, ZRoutedRpcAddPeerPatch

### Community 164 - "bi"
Cohesion: 0.33
Nodes (6): ForgeMap 1.2.0, bi(), Pi(), q(), Ti(), u()

### Community 169 - "BiomeGL"
Cohesion: 0.22
Nodes (3): 2.13.0, bigText(), BiomeGL

### Community 171 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 172 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

### Community 173 - "ServerLog"
Cohesion: 0.27
Nodes (3): Line, ServerLog, ZNetPatchShutdown

### Community 174 - "m"
Cohesion: 0.23
Nodes (12): be(), De(), e(), hi(), m(), p(), pe(), Qe() (+4 more)

### Community 175 - "IEnumerator"
Cohesion: 0.18
Nodes (3): WorldEvents, InvasionsPath, StatePath

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

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 194 - "k"
Cohesion: 0.27
Nodes (11): F(), G(), h(), j(), k(), ke(), ne(), e() (+3 more)

### Community 197 - "addShape"
Cohesion: 0.27
Nodes (11): addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3(), f4(), getBevelVec() (+3 more)

### Community 200 - "playercard.js"
Cohesion: 0.08
Nodes (38): PlayerCard, getJSON(), activityHtml(), ARMOR_SLOTS, at(), BIOME_COL, clock(), connHtml() (+30 more)

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 205 - "system_io"
Cohesion: 0.15
Nodes (3): WebMap.Util, WebMap.MuninModels, WebMap.Tiles

### Community 207 - "Peaks"
Cohesion: 0.26
Nodes (5): Table, Peak, Peaks, All, ZNetPatchStart

### Community 215 - "SerializedFile"
Cohesion: 0.18
Nodes (6): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeNode

### Community 216 - "d"
Cohesion: 0.25
Nodes (9): at(), d(), ht(), i(), Li(), Mi(), v(), W() (+1 more)

### Community 220 - "WebGLCubeRenderTarget"
Cohesion: 0.33
Nodes (5): WebGLCubeRenderTarget, WebGLCubeMaps(), get(), mapTextureMapping(), onTextureDispose()

### Community 224 - ".NewWorld"
Cohesion: 0.14
Nodes (3): 2.10.0, ImageConv, Trails

## Knowledge Gaps
- **246 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+241 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1956 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **74 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `.NewWorld`, `Func`, `Fact`, `HashSet`, `Kitchen`, `Timer`, `i18n.js`, `Portals`, `AuthTests`, `Deeds`, `MapDataServer`, `TerrainPatches`, `WebMap`, `WebMap.cs`, `WorldObjects`, `View3D`, `Pieces`, `Features`?**
  _High betweenness centrality (0.396) - this node is a cross-community bridge._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _246 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007238375659428291 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `Timer` to `three.core.js`, `three.module.js`, `WebXRController`, `Stats`?**
  _High betweenness centrality (0.333) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.0077201901802946855 - nodes in this community are weakly interconnected._
- **Why does `View3D` connect `View3D` to `web/js/view3d.js`, `web/js/sky.js`, `.canopyMaterial`?**
  _High betweenness centrality (0.087) - this node is a cross-community bridge._
- **Should `.push` be split into smaller, more focused modules?**
  _Cohesion score 0.032053316407489686 - nodes in this community are weakly interconnected._