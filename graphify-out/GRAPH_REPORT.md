# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 232 files · ~734,490 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6967 nodes · 16955 edges · 244 communities (161 shown, 83 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 870 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `67f5304a`
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
- TourCam
- BatchedMesh
- Markers
- markers.js
- Dictionary
- .start
- system
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
- GlbWriter
- Kitchen
- JsonWriter
- Kind
- leaflet.js
- WebXRManager
- .applyMatrix4
- .Sweep
- WebGLProgram
- Regex
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
- WithDir
- push
- GLTFLoader.js
- InlineData
- Func
- AnimationAction
- TileJob
- .clone
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
- Layers
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
- .update
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
- Runestones
- PropertyMixer
- PrefabExporter
- RaidLayer
- .FromSerialized
- Hand
- GroundGL
- Texture
- Changelog
- Feed
- FogLayer
- Structures
- arraysEqual
- .LookJson
- map-core.test.mjs
- Locations
- Dictionary
- MeshPhysicalMaterial
- Interpolant
- InterleavedBuffer
- Entry
- ContourGL
- .load
- AnimationClip
- .Export
- particles.js
- StaticFilesTests
- MigrationTests
- LineCurve3
- TextureDecoder
- BufferGeometryUtils.js
- Light
- Français
- ZDOID
- PerspectiveCamera
- i18n.js
- QuadraticBezierCurve
- Portals
- PolyhedronGeometry
- PlayersLayer
- AudioListener
- Fog
- WebMap
- AltBiomeGL
- FogGL
- check.mjs
- RigExporter
- Cat
- bench.mjs
- .Struck
- KitchenTests
- MistGL
- FallbackTileLayer
- SmoothZoom
- vegpack.js
- .parse
- .fetch
- LightShadow
- m
- VideoTexture
- MeshDecoder
- FogMask
- CubicBezierCurve
- BiomeGL
- Preview
- fetchTerrarium
- GuideGL
- OrthographicCamera
- oi
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
- Hotspots
- WebGLState
- TextureDecoder
- Cylindrical
- GLBufferAttribute
- MultiDrawRenderList
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- Timer
- WebMap.cs
- TreesGL
- WebGLMaterials
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- portrait.js
- EventDispatcher
- Weather
- CompressedTexture
- Third-party notices
- system_collections_generic
- .load
- Texture2D
- TextureUtils
- RenderTarget
- testserver.sh
- .WriteIndex
- PointLight
- Uniform
- layers.js
- SerializedFile
- Made
- CylinderGeometry
- WorldSweep
- WebP
- Kind
- Window
- Type
- Kind
- Line
- worldkeys.js
- Traders
- .edgeNormals
- FogExp2
- _points
- MeshPhongMaterial
- CatmullRom
- CubicPoly
- getKeyframeOrder
- probeAsync
- RawShaderMaterial

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

## Communities (244 total, 83 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (219): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+211 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (38): ColorManagement, InterpolationSamplingType, TimestampQuery, TOUCH, arrayCacheF32, arrayCacheI32, _axisDirections, _clearColor (+30 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (33): Box3Helper, buildPlane(), BufferGeometry, CameraHelper, addLine(), addPoint(), CapsuleGeometry, CircleGeometry (+25 more)

### Community 3 - "app.js"
Cohesion: 0.03
Nodes (88): chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM, TILE (+80 more)

### Community 4 - ".subVectors"
Cohesion: 0.04
Nodes (13): a(), c(), handleTriangle(), handleVertex(), checkGeometryIntersection(), checkIntersection$1(), isUniqueEdge(), Line3 (+5 more)

### Community 5 - "WebXRController"
Cohesion: 0.10
Nodes (3): Group, UniformsGroup, WebXRController

### Community 6 - "Vector3"
Cohesion: 0.04
Nodes (12): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+4 more)

### Community 7 - "Object3D"
Cohesion: 0.03
Nodes (13): Camera, CubeCamera, DirectionalLight, FrustumArray, HemisphereLightHelper, LOD, Mesh, Object3D (+5 more)

### Community 8 - "HashSet"
Cohesion: 0.04
Nodes (19): Chart, MaskedRev, Cell, ForestMap, LastStumps, LastTrees, Kind, Other (+11 more)

### Community 9 - "ui.js"
Cohesion: 0.04
Nodes (80): OBJECT_CATS, iconSvg(), byName(), escape(), makeIcon(), activityHtml(), ARMOR_SLOTS, at() (+72 more)

### Community 10 - "Part"
Cohesion: 0.31
Nodes (3): Node, Skin, Part

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (16): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+8 more)

### Community 12 - "Vegetation"
Cohesion: 0.12
Nodes (7): Class, Crunched, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.05
Nodes (19): PlayerCard, MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel() (+11 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.04
Nodes (14): BufferAttribute, copyAttributeData(), createColorManagement(), DataUtils, denormalize(), Float16BufferAttribute, Int16BufferAttribute, Int32BufferAttribute (+6 more)

### Community 16 - "TourCam"
Cohesion: 0.08
Nodes (3): Street, MapCore, TourCam

### Community 17 - "BatchedMesh"
Cohesion: 0.08
Nodes (5): ascIdSort(), BatchedMesh, convertBufferAttribute(), copyArrayContents(), sortedArray()

### Community 18 - "Markers"
Cohesion: 0.06
Nodes (13): BaseOverride, BedSpot, Findable, Markers, Json, Rev, PartTimer, Portal (+5 more)

### Community 19 - "markers.js"
Cohesion: 0.07
Nodes (24): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), collator, dungeonHtml() (+16 more)

### Community 20 - "Dictionary"
Cohesion: 0.07
Nodes (18): Libraries, PrefabsJson, Data, MeshCache, Info, ModelStore, Exported, Hashes (+10 more)

### Community 21 - ".start"
Cohesion: 0.08
Nodes (8): App, BiomeHover, fromLatLng(), esc(), ForgeCard, T(), weatherWord(), windWord()

### Community 22 - "system"
Cohesion: 0.14
Nodes (4): WebMap.Models.Unity, WebMap.MuninModels, WebMap.MuninModels.Unity, WebMap.Models

### Community 23 - "Stats"
Cohesion: 0.08
Nodes (10): What a regression would do on the live server, worst first, DeathWatch, Boss, D, Kit, Spot, Standing, Stats (+2 more)

### Community 24 - "update"
Cohesion: 0.08
Nodes (40): warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer(), WebGLBufferRenderer() (+32 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.11
Nodes (9): MapFog, Revision, ParticleSystem, ThreeDTests, Chunk, Obj, Rock, WorldObjects (+1 more)

### Community 27 - "WebGLShaderCache"
Cohesion: 0.20
Nodes (5): getMaxPrecision(), getChannel(), getParameters(), WebGLShaderCache, WebGLShaderStage

### Community 29 - "measure.js"
Cohesion: 0.06
Nodes (16): rgb(), WorldEdgeGL, BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool (+8 more)

### Community 31 - "Features"
Cohesion: 0.11
Nodes (4): Feature, Features, Grids, Named

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
Cohesion: 0.07
Nodes (21): Armor, Heavy, Light, Mage, Medium, None, Diet, Balanced (+13 more)

### Community 36 - "activity.js"
Cohesion: 0.08
Nodes (17): ActivityLayers, colorRgb(), fmtAgo(), fmtClock(), fmtSpan(), gridOverlay(), HEAT, hslRgb() (+9 more)

### Community 37 - "Func"
Cohesion: 0.13
Nodes (6): Entry, Given, Settings, Live, Stats, WorldEvents

### Community 38 - ".constructor"
Cohesion: 0.07
Nodes (37): arrayNeedsUint32(), createCanvasElement(), createElementNS(), dispose(), WebGLGeometries(), get(), getWireframeAttribute(), onGeometryDispose() (+29 more)

### Community 40 - "GlbWriter"
Cohesion: 0.17
Nodes (7): GlbWriter, Count, Primitive, Result, GlbWriter, Count, Primitive

### Community 43 - "Kind"
Cohesion: 0.15
Nodes (6): Entry, Kind, Boat, Cart, None, Vehicles

### Community 44 - "leaflet.js"
Cohesion: 0.06
Nodes (39): Ae(), at(), be(), d(), De(), ei(), F(), G() (+31 more)

### Community 45 - "WebXRManager"
Cohesion: 0.07
Nodes (12): PlaneGeometry, WebGLAnimation(), onAnimationFrame(), onAnimationFrame(), WebXRDepthSensing, WebXRManager, onInputSourcesChange(), onSessionEnd() (+4 more)

### Community 46 - ".applyMatrix4"
Cohesion: 0.05
Nodes (8): ascSort(), Box2, BoxHelper, checkIntersection(), Frustum, Raycaster, Sphere, testPoint()

### Community 47 - ".Sweep"
Cohesion: 0.07
Nodes (12): Entry, Graves, Demisters, Dungeons, Signature, Inside, Visited, LocationTerrain (+4 more)

### Community 48 - "WebGLProgram"
Cohesion: 0.08
Nodes (26): fetchAttributeLocations(), filterEmptyLine(), generateCubeUVSize(), generateDefines(), generateEnvMapBlendingDefine(), generateEnvMapModeDefine(), generateEnvMapTypeDefine(), generatePrecision() (+18 more)

### Community 49 - "Regex"
Cohesion: 0.20
Nodes (3): HdMaps, HdMapsTests, Sink

### Community 50 - ".equals"
Cohesion: 0.07
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebXRManager"
Cohesion: 0.09
Nodes (9): renderTarget(), ExternalTexture, WebGLRenderer, renderObject(), renderObjects(), renderTransmissionPass(), drawBuffers(), viewport() (+1 more)

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "net.js"
Cohesion: 0.08
Nodes (7): ChunkStore, ObjectStore, RegionLoader, VegStore, RuinsLayer, RuinStore, getJSON()

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "Euler"
Cohesion: 0.14
Nodes (3): Euler, onQuaternionChange(), onRotationChange()

### Community 57 - "Matrix4"
Cohesion: 0.05
Nodes (5): AxesHelper, Bone, flattenJSON(), Matrix4, Skeleton

### Community 58 - "Color"
Cohesion: 0.07
Nodes (7): Color, damp(), euclideanModulo(), hue2rgb(), LinearToSRGB(), pingpong(), SRGBToLinear()

### Community 60 - "Box3"
Cohesion: 0.05
Nodes (6): Box3, InstancedBufferAttribute, InstancedMesh, makeClipAdditive(), Matrix2, satForAxes()

### Community 62 - "TileStore"
Cohesion: 0.08
Nodes (9): TileMath, ChunksPerSide, TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered (+1 more)

### Community 63 - "markercanvas.js"
Cohesion: 0.10
Nodes (13): colors, asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache (+5 more)

### Community 64 - "WithDir"
Cohesion: 0.11
Nodes (6): WebMapConfig, HeightMaxZoom, LightModeTests, PinsTests, File_, WithDir

### Community 65 - "push"
Cohesion: 0.09
Nodes (29): shadowCastingAndTexturingLightsFirst(), ShadowUniformsCache(), UniformsCache(), WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights(), setup() (+21 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.07
Nodes (11): Auth, Session, ChatCommands, Command, Kind, Delete, None, Pin (+3 more)

### Community 68 - "Func"
Cohesion: 0.08
Nodes (9): Body, ChatRelay, Discord, Token, DiscordMessage, DiscordRef, Result, ChatRelayTests (+1 more)

### Community 70 - "TileJob"
Cohesion: 0.12
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 71 - ".clone"
Cohesion: 0.06
Nodes (17): CatmullRomCurve3, cloneUniformsGroups(), Curve, addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces() (+9 more)

### Community 72 - "PMREMGenerator"
Cohesion: 0.11
Nodes (17): ShaderMaterial, _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial(), PMREMGenerator, _setViewport(), WebGLCubeMaps() (+9 more)

### Community 73 - ".parseObject"
Cohesion: 0.06
Nodes (23): AnimationLoader, AudioLoader, handleError(), BufferGeometryLoader, getArrayBuffer(), getInterleavedBuffer(), CompressedTextureLoader, loadTexture() (+15 more)

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
Cohesion: 0.11
Nodes (6): BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, QuaternionKeyframeTrack, StringKeyframeTrack, VectorKeyframeTrack

### Community 79 - "Items"
Cohesion: 0.14
Nodes (3): Items, Ready, ItemsTests

### Community 80 - "MapDataServer"
Cohesion: 0.06
Nodes (5): MapDataServer, PlayersWs, MapMessage, WebSocketHandler, ZoneSystemLoadPatch

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "TextureExtractor"
Cohesion: 0.15
Nodes (6): At, Source, TextureExtractor, LastFound, LastReport, Running

### Community 83 - "Layers"
Cohesion: 0.12
Nodes (4): 2.9.1, intersect(), Layers, StereoCamera

### Community 86 - "BundleFile"
Cohesion: 0.15
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 88 - "HashSet"
Cohesion: 0.10
Nodes (12): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running (+4 more)

### Community 89 - "SerializedFile"
Cohesion: 0.19
Nodes (7): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode

### Community 90 - "GLTFParser"
Cohesion: 0.20
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.08
Nodes (7): FeaturesTests, SettingsTests, Grid, Cell, J, StatsTests, VersionTests

### Community 93 - "BuildingsGL"
Cohesion: 0.09
Nodes (3): BuildingsGL, RECT_LAYOUT(), RuinsGL

### Community 95 - "Activity"
Cohesion: 0.24
Nodes (4): Activity, Snap, Trail, ActivityTests

### Community 96 - "web/js/view3d.js"
Cohesion: 0.12
Nodes (11): lookKey(), _ahead, AROUND, bigFromAfar(), facing(), fallbackColor(), IDENTITY, KEYS (+3 more)

### Community 97 - "get"
Cohesion: 0.10
Nodes (62): setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), WebGLCapabilities(), getMaxAnisotropy(), textureFormatReadable(), textureTypeReadable() (+54 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.13
Nodes (22): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+14 more)

### Community 99 - "BundleFile"
Cohesion: 0.16
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "ModelStore"
Cohesion: 0.08
Nodes (16): Data, MeshCache, Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted (+8 more)

### Community 102 - "Path"
Cohesion: 0.08
Nodes (5): CurvePath, Path, Shape, ShapePath, toShapesNoHoles()

### Community 104 - "TerrainPatches"
Cohesion: 0.11
Nodes (8): Heights, KeepSamples, Job, Served, Patch, TerrainPatches, Count, Job

### Community 105 - "Using the map"
Cohesion: 0.10
Nodes (20): Chat commands, Checking the viewer against a live server, Coming from WebMap, Configuration, Discord, Features, Full-quality textures (optional), Install (+12 more)

### Community 106 - "Runestones"
Cohesion: 0.17
Nodes (4): Kind, Kind, Runestones, Stone

### Community 109 - "RaidLayer"
Cohesion: 0.23
Nodes (3): ago(), areaImage(), RaidLayer

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.22
Nodes (3): GroundGL, perSide(), span()

### Community 113 - "Texture"
Cohesion: 0.08
Nodes (5): CanvasTexture, DepthTexture, FramebufferTexture, Source, Texture

### Community 114 - "Changelog"
Cohesion: 0.11
Nodes (19): 2.11.0, 2.14.0, 2.15.0, 2.16.0, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog (+11 more)

### Community 115 - "Feed"
Cohesion: 0.20
Nodes (6): Ev, Feed, Keep, RecentJson, FeedTests, SkipToMorningPatch

### Community 117 - "Structures"
Cohesion: 0.06
Nodes (19): ChunkCache, Line, Chunk, Ruins, IndexJson, LastChanged, Total, Site (+11 more)

### Community 118 - "arraysEqual"
Cohesion: 0.21
Nodes (19): allocTexUnits(), arraysEqual(), copyArray(), setValueM2(), setValueM3(), setValueM4(), setValueT1Array(), setValueT2DArrayArray() (+11 more)

### Community 119 - ".LookJson"
Cohesion: 0.24
Nodes (5): Item, Joints, Look, Rig, RigTests

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 122 - "Dictionary"
Cohesion: 0.17
Nodes (4): HotspotsTests, BuildHistory, Snap, JsonParser

### Community 123 - "MeshPhysicalMaterial"
Cohesion: 0.12
Nodes (3): MeshLambertMaterial, MeshPhysicalMaterial, MeshStandardMaterial

### Community 124 - "Interpolant"
Cohesion: 0.22
Nodes (3): CubicInterpolant, DiscreteInterpolant, Interpolant

### Community 125 - "InterleavedBuffer"
Cohesion: 0.14
Nodes (3): generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer

### Community 126 - "Entry"
Cohesion: 0.09
Nodes (13): 2.12.0, Entry, ItemIcons, Dir, Entry, MapIcons, Dir, Format (+5 more)

### Community 127 - "ContourGL"
Cohesion: 0.17
Nodes (4): ContourGL, labelImage(), span(), screenArea()

### Community 128 - ".load"
Cohesion: 0.14
Nodes (5): getImageURIMimeType(), GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension, LoaderUtils

### Community 129 - "AnimationClip"
Cohesion: 0.12
Nodes (5): AnimationClip, AnimationUtils, getTrackTypeForValueTypeName(), NumberKeyframeTrack, parseKeyframeTrack()

### Community 131 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 133 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 134 - "LineCurve3"
Cohesion: 0.15
Nodes (6): LineCurve3, TubeGeometry, generateBufferData(), generateIndices(), generateSegment(), generateUVs()

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - "Light"
Cohesion: 0.11
Nodes (5): AmbientLight, HemisphereLight, Light, LightProbe, RectAreaLight

### Community 138 - "Français"
Cohesion: 0.12
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 139 - "ZDOID"
Cohesion: 0.33
Nodes (3): Deeds, Last, DeedsTests

### Community 141 - "i18n.js"
Cohesion: 0.15
Nodes (9): 2.16.1, Gear, fill(), has(), name(), num(), t(), tn() (+1 more)

### Community 142 - "QuadraticBezierCurve"
Cohesion: 0.12
Nodes (6): QuadraticBezier(), QuadraticBezierCurve, QuadraticBezierCurve3, QuadraticBezierP0(), QuadraticBezierP1(), QuadraticBezierP2()

### Community 143 - "Portals"
Cohesion: 0.15
Nodes (5): Testing, Entry, Last, Portals, PortalsTests

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 145 - "PlayersLayer"
Cohesion: 0.18
Nodes (6): toLatLng(), PlayersLayer, setupTour(), refresh(), takeWalked(), T()

### Community 146 - "AudioListener"
Cohesion: 0.12
Nodes (5): AudioContext, AudioListener, Clock, ImageUtils, serializeImage()

### Community 148 - "WebMap"
Cohesion: 0.08
Nodes (7): DiscordWebHook, Line, ServerLog, WebMap, ZNetPatchSetServer, ZNetPatchShutdown, ZoneSystemPatch

### Community 151 - "check.mjs"
Cohesion: 0.32
Nodes (11): [BASE, PORT, OUT], check(), map(), open(), plan(), players(), portals(), sleep() (+3 more)

### Community 153 - "Cat"
Cohesion: 0.29
Nodes (7): Cat, Bush, Other, Piece, Rock, Skip, Tree

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

### Community 162 - ".fetch"
Cohesion: 0.20
Nodes (4): hexRgb(), materialRgb(), PackedRegions, packRects()

### Community 164 - "m"
Cohesion: 0.18
Nodes (14): ForgeMap 1.2.0, bi(), e(), hi(), m(), Pi(), q(), Qe() (+6 more)

### Community 166 - "MeshDecoder"
Cohesion: 0.25
Nodes (3): Decoded, MeshDecoder, P

### Community 167 - "FogMask"
Cohesion: 0.14
Nodes (4): TilesTests, FogMask, Kept, WorldPicture

### Community 168 - "CubicBezierCurve"
Cohesion: 0.12
Nodes (7): CubicBezier(), CubicBezierCurve, CubicBezierCurve3, CubicBezierP0(), CubicBezierP1(), CubicBezierP2(), CubicBezierP3()

### Community 170 - "Preview"
Cohesion: 0.14
Nodes (5): Announce, Token, Pending, Preview, PreviewTests

### Community 171 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 172 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

### Community 174 - "oi"
Cohesion: 0.67
Nodes (4): Je(), ni(), oi(), si()

### Community 175 - "IEnumerator"
Cohesion: 0.11
Nodes (9): Peak, Peaks, All, ZNetPatchDisconnect, ZNetPatchStart, ZRoutedRpcAddPeerPatch, WorldEvents, InvasionsPath (+1 more)

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

### Community 186 - "WebGLState"
Cohesion: 0.20
Nodes (18): WebGLState(), ColorBuffer(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), reset(), scissor() (+10 more)

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 197 - "WebGLMaterials"
Cohesion: 0.11
Nodes (29): cloneUniforms(), getUnlitUniformColorSpace(), mergeUniforms(), WebGLBackground(), addToRenderList(), getBackground(), render(), setClear() (+21 more)

### Community 200 - "portrait.js"
Cohesion: 0.19
Nodes (12): PlayerCard, bodyTexture(), curlNoise(), finish(), image(), info(), lib(), model() (+4 more)

### Community 201 - "EventDispatcher"
Cohesion: 0.11
Nodes (6): EventDispatcher, ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), LoadingManager

### Community 203 - "CompressedTexture"
Cohesion: 0.25
Nodes (3): CompressedArrayTexture, CompressedCubeTexture, CompressedTexture

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 209 - "RenderTarget"
Cohesion: 0.09
Nodes (10): CubeTexture, Data3DTexture, DataArrayTexture, RenderTarget, RenderTarget3D, WebGL3DRenderTarget, WebGLArrayRenderTarget, WebGLCubeRenderTarget (+2 more)

### Community 215 - "SerializedFile"
Cohesion: 0.19
Nodes (7): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode

### Community 217 - "Made"
Cohesion: 0.33
Nodes (6): Made, Brewed, Burnt, Cooked, Honey, Smelted

### Community 222 - "Kind"
Cohesion: 0.25
Nodes (8): Kind, Chest, Gate, Generator, Mining, Monster, None, Pickable

### Community 223 - "Window"
Cohesion: 0.27
Nodes (3): Ping, Window, PingTests

### Community 224 - "Type"
Cohesion: 0.40
Nodes (5): Type, Brew, Cook, Hive, Smelt

### Community 225 - "Kind"
Cohesion: 0.50
Nodes (4): Kind, Kill, Rock, Tree

### Community 232 - "Line"
Cohesion: 0.07
Nodes (10): ArrowHelper, BoxGeometry, DirectionalLightHelper, Line, LineLoop, MeshBasicMaterial, PlaneHelper, PointLightHelper (+2 more)

## Knowledge Gaps
- **246 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+241 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1972 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **83 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `Timer`, `InlineData`, `Func`, `HashSet`, `TerrainPatches`, `Fact`, `ZDOID`, `i18n.js`, `Portals`, `MapDataServer`, `WebMap`, `WorldObjects`, `.Struck`, `.update`, `Features`?**
  _High betweenness centrality (0.381) - this node is a cross-community bridge._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _246 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.008 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `Timer` to `three.core.js`, `EventDispatcher`, `three.module.js`, `Stats`?**
  _High betweenness centrality (0.319) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.008260415306255714 - nodes in this community are weakly interconnected._
- **Why does `View3D` connect `View3D` to `web/js/view3d.js`, `web/js/sky.js`, `.edgeNormals`, `.update`?**
  _High betweenness centrality (0.074) - this node is a cross-community bridge._
- **Should `.push` be split into smaller, more focused modules?**
  _Cohesion score 0.03216461891918889 - nodes in this community are weakly interconnected._