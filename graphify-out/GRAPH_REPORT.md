# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 232 files · ~734,235 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6989 nodes · 17003 edges · 223 communities (149 shown, 74 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 869 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `8e767e4b`
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
- WithDir
- PrefabExporter
- JsonWriter
- List
- leaflet.js
- WebXRManager
- .applyMatrix4
- TileMath
- AuthTests
- .build
- .equals
- renderTransmissionPass
- Vector4
- Veg
- net.js
- PropertyBinding
- Feed
- Matrix4
- Color
- Quaternion
- Box3
- GateTests
- TileStore
- markercanvas.js
- ZNetPeer
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
- PositionalAudio
- MapFog
- .distanceTo
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
- map-core.test.mjs
- Locations
- Dictionary
- GuideGL
- Interpolant
- InterleavedBuffer
- ContourGL
- .load
- AnimationClip
- TreesGL
- particles.js
- TilesTests
- MigrationTests
- AudioListener
- TextureDecoder
- BufferGeometryUtils.js
- Announce
- Français
- Kitchen
- PerspectiveCamera
- Changelog
- QuadraticBezierCurve
- JsonElement
- PolyhedronGeometry
- PlayersLayer
- Clock
- Trails
- ServerLog
- AltBiomeGL
- ForestMap
- check.mjs
- .Observe
- ChatRelay
- bench.mjs
- Controls
- Weather
- MistGL
- net.js
- SmoothZoom
- vegpack.js
- .parse
- Light
- MeshCache
- FogGL
- CubicBezierCurve3
- ShaderMaterial
- FogMask
- CubicBezierCurve
- Cat
- Preview
- fetchTerrarium
- bi
- WebSocketHandler
- IEnumerator
- MuninConfig
- EllipseCurve
- Material
- oi
- WebMap.Tests.csproj
- WebMap.csproj
- GLTFMaterialsDispersionExtension
- Spherical
- render
- createColorManagement
- TextureDecoder
- Cylindrical
- GLBufferAttribute
- QuadraticBezierCurve3
- MultiDrawRenderList
- ForgeMap — translation brief (read fully before editing)
- manifest.json
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
- TextureUtils
- Rgba32
- testserver.sh
- Chart
- Uniform
- LocationTerrain
- SerializedFile
- StaticFilesTests
- WebP
- Window
- Line
- worldkeys.js
- WorldEvents

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

## Communities (223 total, 74 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (238): _addedEvent, _alignedPosition, ArrayCamera, _axis, _basePosition, _batchIntersects, _boneMatrix, _box (+230 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (74): _cache, DefaultLoadingManager, InterpolationSamplingMode, InterpolationSamplingType, MathUtils, TimestampQuery, UniformsUtils, addUniform() (+66 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (38): Box3Helper, buildPlane(), BufferGeometry, CameraHelper, addLine(), addPoint(), CapsuleGeometry, CircleGeometry (+30 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (78): chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM, TILE (+70 more)

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
Nodes (10): Camera, CubeCamera, DirectionalLight, DirectionalLightShadow, FrustumArray, Object3D, OrthographicCamera, _points (+2 more)

### Community 8 - ".Sweep"
Cohesion: 0.06
Nodes (16): Entry, Graves, Demisters, Dungeons, Signature, Inside, Visited, Kind (+8 more)

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (59): iconSvg(), escape(), makeIcon(), PALETTE, statsHtml(), BIOME_SVG, breakable(), BUILD_SVG (+51 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (16): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+8 more)

### Community 12 - "Vegetation"
Cohesion: 0.14
Nodes (7): Class, Crunched, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.06
Nodes (18): MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel(), onPointerDown() (+10 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.04
Nodes (8): BufferAttribute, convertBufferAttribute(), copyAttributeData(), DataUtils, denormalize(), Float16BufferAttribute, InterleavedBufferAttribute, sortedArray()

### Community 17 - "BatchedMesh"
Cohesion: 0.04
Nodes (11): ascIdSort(), AxesHelper, BatchedMesh, Bone, CatmullRomCurve3, copyArrayContents(), DataTexture, flattenJSON() (+3 more)

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
Cohesion: 0.08
Nodes (8): App, BiomeHover, fromLatLng(), esc(), ForgeCard, T(), weatherWord(), windWord()

### Community 22 - "get"
Cohesion: 0.08
Nodes (70): getByteLength(), getTextureTypeByteLength(), setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), WebGLCapabilities(), getMaxAnisotropy() (+62 more)

### Community 23 - "Stats"
Cohesion: 0.09
Nodes (8): What a regression would do on the live server, worst first, Boss, D, Kit, Spot, Standing, Stats, StatsTests

### Community 24 - "update"
Cohesion: 0.05
Nodes (65): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+57 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.14
Nodes (7): ParticleSystem, ThreeDTests, Chunk, Obj, Rock, WorldObjects, Total

### Community 27 - "BuildingsGL"
Cohesion: 0.10
Nodes (7): BuildingsGL, hexRgb(), materialRgb(), PackedRegions, packRects(), RECT_LAYOUT(), RuinsGL

### Community 29 - "measure.js"
Cohesion: 0.06
Nodes (16): rgb(), WorldEdgeGL, BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool (+8 more)

### Community 31 - "Features"
Cohesion: 0.10
Nodes (6): Testing, Feature, Features, Grids, Named, Fnv

### Community 32 - "ForgeCanvas"
Cohesion: 0.06
Nodes (15): Tour, prefabs, DeathsLayer, fogUsers, ForgeCanvas, loadFog(), MC, walkedFn() (+7 more)

### Community 34 - "Material"
Cohesion: 0.03
Nodes (18): Euler, LineDashedMaterial, Material, MeshDepthMaterial, MeshDistanceMaterial, MeshLambertMaterial, MeshMatcapMaterial, MeshNormalMaterial (+10 more)

### Community 35 - "Gear"
Cohesion: 0.07
Nodes (21): Armor, Heavy, Light, Mage, Medium, None, Diet, Balanced (+13 more)

### Community 36 - "activity.js"
Cohesion: 0.08
Nodes (17): ActivityLayers, colorRgb(), fmtAgo(), fmtClock(), fmtSpan(), gridOverlay(), HEAT, hslRgb() (+9 more)

### Community 37 - "Func"
Cohesion: 0.19
Nodes (3): Entry, Given, Settings

### Community 38 - ".constructor"
Cohesion: 0.10
Nodes (25): createCanvasElement(), createElementNS(), WebGLAnimation(), onAnimationFrame(), refreshFogUniforms(), update(), disposeTexture(), dispose() (+17 more)

### Community 40 - "WithDir"
Cohesion: 0.11
Nodes (6): HdMaps, HdMapsTests, Sink, PinsTests, File_, WithDir

### Community 41 - "PrefabExporter"
Cohesion: 0.06
Nodes (10): GlbWriter, Count, Primitive, PrefabExporter, Result, GlbWriter, Count, Primitive (+2 more)

### Community 43 - "List"
Cohesion: 0.06
Nodes (16): Entry, Kind, Pieces, PiecesTests, Peak, Peaks, All, Kind (+8 more)

### Community 44 - "leaflet.js"
Cohesion: 0.06
Nodes (47): Ae(), at(), be(), d(), De(), e(), ei(), F() (+39 more)

### Community 45 - "WebXRManager"
Cohesion: 0.05
Nodes (12): renderTarget(), ExternalTexture, WebGLRenderer, WebXRDepthSensing, WebXRManager, onAnimationFrame(), onInputSourcesChange(), onSessionEnd() (+4 more)

### Community 46 - ".applyMatrix4"
Cohesion: 0.04
Nodes (10): ascSort(), Box2, BoxHelper, checkIntersection(), Frustum, InstancedBufferAttribute, InstancedMesh, Raycaster (+2 more)

### Community 48 - "AuthTests"
Cohesion: 0.15
Nodes (3): Auth, Session, AuthTests

### Community 50 - ".equals"
Cohesion: 0.09
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "renderTransmissionPass"
Cohesion: 0.12
Nodes (8): WebGLRenderTarget, getMaxPrecision(), getChannel(), getParameters(), renderObject(), renderObjects(), renderTransmissionPass(), WebGLShaderCache

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "net.js"
Cohesion: 0.05
Nodes (19): ChunkStore, ObjectStore, parseVeg(), RegionLoader, VegStore, FogLayer, RuinsLayer, RuinStore (+11 more)

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "Feed"
Cohesion: 0.23
Nodes (5): Ev, Feed, Keep, RecentJson, FeedTests

### Community 61 - "GateTests"
Cohesion: 0.08
Nodes (4): WebMapConfig, HeightMaxZoom, GateTests, LightModeTests

### Community 62 - "TileStore"
Cohesion: 0.12
Nodes (7): TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered, RenderMsTotal

### Community 63 - "markercanvas.js"
Cohesion: 0.10
Nodes (13): colors, asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache (+5 more)

### Community 64 - "ZNetPeer"
Cohesion: 0.15
Nodes (4): Ping, ZNetPatchDisconnect, ZNetPatchStart, ZRoutedRpcAddPeerPatch

### Community 65 - "push"
Cohesion: 0.09
Nodes (28): shadowCastingAndTexturingLightsFirst(), ShadowUniformsCache(), UniformsCache(), WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights(), setup() (+20 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.11
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Func"
Cohesion: 0.11
Nodes (6): Body, Discord, Token, DiscordRef, Result, DiscordTests

### Community 70 - "TileJob"
Cohesion: 0.12
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 71 - "Curve"
Cohesion: 0.09
Nodes (3): Curve, LineCurve, LineCurve3

### Community 72 - "PMREMGenerator"
Cohesion: 0.14
Nodes (8): Mesh, _createRenderTarget(), PMREMGenerator, _setViewport(), WebGLCubeUVMaps(), dispose(), get(), isCubeTextureComplete()

### Community 73 - "Loader"
Cohesion: 0.05
Nodes (26): AnimationLoader, AudioLoader, handleError(), BufferGeometryLoader, CompressedTextureLoader, loadTexture(), CubeTextureLoader, loadTexture() (+18 more)

### Community 75 - "web/js/sky.js"
Cohesion: 0.10
Nodes (10): DARK, DAY, DUSK, GROUND, HAZE, lerp(), Lighting, NIGHT (+2 more)

### Community 76 - "RigBuilder"
Cohesion: 0.13
Nodes (13): HD, bakeSkin(), hdFor(), JOINT_ORDER, loadHd(), lookKey(), MR_METAL, MR_ROUGH (+5 more)

### Community 77 - ".constructor"
Cohesion: 0.07
Nodes (7): GLTFLoader, GLTFMaterialsBumpExtension, GLTFMaterialsEmissiveStrengthExtension, GLTFMaterialsIorExtension, GLTFMaterialsIridescenceExtension, GLTFMeshGpuInstancing, GLTFMeshoptCompression

### Community 78 - "KeyframeTrack"
Cohesion: 0.08
Nodes (10): Coming from WebMap, Install, BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, LinearInterpolant, QuaternionKeyframeTrack, StringKeyframeTrack (+2 more)

### Community 79 - "Items"
Cohesion: 0.15
Nodes (3): Items, Ready, ItemsTests

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "TextureExtractor"
Cohesion: 0.13
Nodes (6): At, Source, TextureExtractor, LastFound, LastReport, Running

### Community 83 - "WebMap"
Cohesion: 0.10
Nodes (5): DiscordWebHook, WebMap, ZNetPatchSetServer, ZoneSystemLoadPatch, ZoneSystemPatch

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
Cohesion: 0.12
Nodes (6): FeaturesTests, PreviewTests, SettingsTests, Grid, Cell, VersionTests

### Community 93 - "MapFog"
Cohesion: 0.16
Nodes (4): MapFog, Revision, Entry, Traders

### Community 95 - "Activity"
Cohesion: 0.24
Nodes (4): Activity, Snap, Trail, ActivityTests

### Community 96 - "web/js/view3d.js"
Cohesion: 0.11
Nodes (14): _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), facing(), fallbackColor() (+6 more)

### Community 97 - "WebGLState"
Cohesion: 0.18
Nodes (19): WebGLState(), activeTexture(), ColorBuffer(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), reset() (+11 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.17
Nodes (21): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+13 more)

### Community 99 - "BundleFile"
Cohesion: 0.15
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "ModelStore"
Cohesion: 0.09
Nodes (14): Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted, PrefabsJson, QueueLength (+6 more)

### Community 104 - "TerrainPatches"
Cohesion: 0.11
Nodes (8): Heights, KeepSamples, Job, Served, Patch, TerrainPatches, Count, Job

### Community 105 - "Using the map"
Cohesion: 0.11
Nodes (18): Chat commands, Checking the viewer against a live server, Configuration, Discord, Features, Full-quality textures (optional), Licence and credit, Local test server (+10 more)

### Community 106 - "addToRenderList"
Cohesion: 0.21
Nodes (8): getUnlitUniformColorSpace(), PlaneGeometry, WebGLBackground(), addToRenderList(), dispose(), getBackground(), render(), setClear()

### Community 108 - "Part"
Cohesion: 0.09
Nodes (10): Node, Skin, Item, Joints, Look, Rig, Part, Player (+2 more)

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
Cohesion: 0.22
Nodes (3): GroundGL, perSide(), span()

### Community 113 - "Texture"
Cohesion: 0.03
Nodes (16): CanvasTexture, CubeTexture, Data3DTexture, DataArrayTexture, DepthTexture, FramebufferTexture, Matrix3, RenderTarget (+8 more)

### Community 114 - "BiomeGL"
Cohesion: 0.24
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

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 122 - "Dictionary"
Cohesion: 0.11
Nodes (6): HotspotsTests, BuildHistory, Snap, Hotspots, Json, JsonParser

### Community 123 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

### Community 124 - "Interpolant"
Cohesion: 0.18
Nodes (3): CubicInterpolant, DiscreteInterpolant, Interpolant

### Community 125 - "InterleavedBuffer"
Cohesion: 0.10
Nodes (5): getArrayBuffer(), getInterleavedBuffer(), generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer

### Community 127 - "ContourGL"
Cohesion: 0.17
Nodes (4): ContourGL, labelImage(), span(), screenArea()

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

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - "Announce"
Cohesion: 0.32
Nodes (3): Announce, Token, Pending

### Community 138 - "Français"
Cohesion: 0.12
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 139 - "Kitchen"
Cohesion: 0.06
Nodes (24): Deeds, DeedsGonePatch, DeedsRoutePatch, Kind, Kill, Rock, Tree, Last (+16 more)

### Community 140 - "PerspectiveCamera"
Cohesion: 0.04
Nodes (8): Layers, LightShadow, PerspectiveCamera, PointLight, PointLightShadow, SpotLight, SpotLightShadow, StereoCamera

### Community 141 - "Changelog"
Cohesion: 0.08
Nodes (22): 2.11.0, 2.14.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog (+14 more)

### Community 143 - "JsonElement"
Cohesion: 0.14
Nodes (5): Entry, Last, Portals, PortalsTests, J

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 145 - "PlayersLayer"
Cohesion: 0.18
Nodes (6): toLatLng(), PlayersLayer, setupTour(), refresh(), takeWalked(), T()

### Community 146 - "Clock"
Cohesion: 0.19
Nodes (4): AudioContext, Clock, ImageUtils, SRGBToLinear()

### Community 150 - "ForestMap"
Cohesion: 0.07
Nodes (13): 2.10.0, Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump (+5 more)

### Community 151 - "check.mjs"
Cohesion: 0.17
Nodes (17): 2.15.0, HTTP endpoints, [BASE, PORT, OUT], check(), map(), open(), plan(), players() (+9 more)

### Community 152 - ".Observe"
Cohesion: 0.32
Nodes (3): DeathWatch, ZRoutedRpcPatch, ZRoutedRpcRoutePatch

### Community 153 - "ChatRelay"
Cohesion: 0.26
Nodes (3): ChatRelay, DiscordMessage, ChatRelayTests

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
Cohesion: 0.11
Nodes (5): AmbientLight, HemisphereLight, Light, LightProbe, RectAreaLight

### Community 163 - "MeshCache"
Cohesion: 0.24
Nodes (4): Data, MeshCache, Data, MeshCache

### Community 166 - "ShaderMaterial"
Cohesion: 0.13
Nodes (11): BoxGeometry, cloneUniforms(), cloneUniformsGroups(), mergeUniforms(), RawShaderMaterial, ShaderMaterial, WebGLCubeRenderTarget, _getBlurShader() (+3 more)

### Community 169 - "Cat"
Cohesion: 0.29
Nodes (7): Cat, Bush, Other, Piece, Rock, Skip, Tree

### Community 171 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 172 - "bi"
Cohesion: 0.33
Nodes (6): ForgeMap 1.2.0, bi(), Pi(), q(), Ti(), u()

### Community 175 - "IEnumerator"
Cohesion: 0.16
Nodes (4): SkipToMorningPatch, WorldEvents, InvasionsPath, StatePath

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

### Community 184 - "render"
Cohesion: 0.43
Nodes (4): load(), message(), render(), Spot

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 197 - "WebGLMaterials"
Cohesion: 0.33
Nodes (14): WebGLMaterials(), refreshMaterialUniforms(), refreshTransformUniform(), refreshUniformsCommon(), refreshUniformsDash(), refreshUniformsDistance(), refreshUniformsLine(), refreshUniformsMatcap() (+6 more)

### Community 200 - "portrait.js"
Cohesion: 0.08
Nodes (34): PlayerCard, stats, activityHtml(), ARMOR_SLOTS, at(), BIOME_COL, clock(), connHtml() (+26 more)

### Community 201 - "EventDispatcher"
Cohesion: 0.06
Nodes (10): 2.9.1, EventDispatcher, handleVisibilityChange(), ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), intersect() (+2 more)

### Community 202 - "addShape"
Cohesion: 0.07
Nodes (14): CurvePath, addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3(), f4() (+6 more)

### Community 203 - "CompressedTexture"
Cohesion: 0.25
Nodes (3): CompressedArrayTexture, CompressedCubeTexture, CompressedTexture

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 205 - "system"
Cohesion: 0.11
Nodes (4): WebMap.Models.Unity, WebMap.MuninModels, WebMap.MuninModels.Unity, WebMap.Models

### Community 211 - "Chart"
Cohesion: 0.14
Nodes (4): Chart, MaskedRev, StaticCoroutine, StaticCoroutineRunner

### Community 214 - "LocationTerrain"
Cohesion: 0.20
Nodes (4): LocationTerrain, Count, Mod, Patch

### Community 215 - "SerializedFile"
Cohesion: 0.16
Nodes (8): TypeInfo, LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode

### Community 232 - "Line"
Cohesion: 0.07
Nodes (10): ArrowHelper, ConeGeometry, CylinderGeometry, DirectionalLightHelper, Line, MeshBasicMaterial, PlaneHelper, PointLightHelper (+2 more)

### Community 236 - "WorldEvents"
Cohesion: 0.33
Nodes (3): Live, Stats, WorldEvents

## Knowledge Gaps
- **246 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+241 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1979 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **74 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `Kitchen`, `Changelog`, `JsonElement`, `Trails`, `ForestMap`, `.Observe`, `ChatRelay`, `WorldObjects`, `View3D`, `Features`, `List`, `AuthTests`, `Func`, `EventDispatcher`, `MapDataServer`, `Chart`, `WebMap`, `MapFog`, `TerrainPatches`?**
  _High betweenness centrality (0.378) - this node is a cross-community bridge._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _246 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.00729268476054432 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `EventDispatcher` to `three.core.js`, `three.module.js`, `Stats`?**
  _High betweenness centrality (0.319) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007749733380732315 - nodes in this community are weakly interconnected._
- **Why does `View3D` connect `View3D` to `web/js/view3d.js`, `web/js/sky.js`, `RigBuilder`?**
  _High betweenness centrality (0.069) - this node is a cross-community bridge._
- **Should `.push` be split into smaller, more focused modules?**
  _Cohesion score 0.03159071847917249 - nodes in this community are weakly interconnected._