# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 232 files · ~733,951 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6964 nodes · 16947 edges · 221 communities (153 shown, 68 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 870 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `9485cf88`
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
- PositionalAudio
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
- .Sweep
- AuthTests
- Regex
- .equals
- WebXRManager
- Vector4
- Veg
- net.js
- PropertyBinding
- .FromSerialized
- Matrix4
- Color
- Quaternion
- Box3
- Fact
- TileStore
- markercanvas.js
- .ReadConfigFile
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
- .FromSerialized
- SerializedFile
- GLTFParser
- Fact
- ShapesCanvas
- BuildingsGL
- PinsTests
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
- FogLayer
- Structures
- arraysEqual
- .LookJson
- map-core.test.mjs
- Locations
- Dictionary
- StructuresLayer
- Interpolant
- .connect
- Entry
- ContourGL
- .load
- AnimationClip
- .Export
- particles.js
- StaticFilesTests
- MigrationTests
- AudioListener
- TextureDecoder
- BufferGeometryUtils.js
- Light
- Français
- ShapePath
- PerspectiveCamera
- i18n.js
- QuadraticBezierCurve
- Portals
- PolyhedronGeometry
- PlayersLayer
- .getContext
- Fog
- WebMap
- AltBiomeGL
- FogGL
- check.mjs
- WorldEdgeGL
- Cat
- bench.mjs
- Clock
- MistGL
- FallbackTileLayer
- SmoothZoom
- vegpack.js
- .parse
- Shape
- AudioAnalyser
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
- oi
- IEnumerator
- MuninConfig
- EllipseCurve
- Material
- QuadraticBezierCurve3
- WebMap.Tests.csproj
- WebMap.csproj
- GLTFMaterialsDispersionExtension
- Spherical
- render
- MapFog
- WebGLState
- Cylindrical
- GLBufferAttribute
- LocationTerrain
- MultiDrawRenderList
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- CubicBezierCurve
- WebGLMaterials
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- playercard.js
- EventDispatcher
- Third-party notices
- system_io
- .load
- TextureUtils
- ShaderMaterial
- testserver.sh
- Uniform
- layers.js
- SerializedFile
- WebP
- Kind
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

## Communities (221 total, 68 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (239): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+231 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (79): DefaultLoadingManager, InterpolationSamplingMode, InterpolationSamplingType, MathUtils, TimestampQuery, TOUCH, addUniform(), arrayCacheF32 (+71 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (40): buildPlane(), BufferGeometry, CameraHelper, addLine(), addPoint(), CapsuleGeometry, CircleGeometry, generateCap() (+32 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (78): BiomeHover, chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM (+70 more)

### Community 4 - ".subVectors"
Cohesion: 0.04
Nodes (13): a(), c(), handleTriangle(), handleVertex(), checkGeometryIntersection(), checkIntersection$1(), Frustum, isUniqueEdge() (+5 more)

### Community 5 - "WebXRController"
Cohesion: 0.10
Nodes (3): Group, UniformsGroup, WebXRController

### Community 6 - "Vector3"
Cohesion: 0.03
Nodes (14): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+6 more)

### Community 7 - "Object3D"
Cohesion: 0.03
Nodes (12): Camera, CubeCamera, DirectionalLightHelper, DirectionalLightShadow, FrustumArray, LOD, Object3D, OrthographicCamera (+4 more)

### Community 8 - "HashSet"
Cohesion: 0.06
Nodes (15): 2.10.0, Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump (+7 more)

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (54): iconSvg(), escape(), makeIcon(), BIOME_SVG, breakable(), BUILD_SVG, BUSH_SVG, busyChart() (+46 more)

### Community 10 - "Part"
Cohesion: 0.14
Nodes (6): Node, Skin, Part, Player, RigExporter, StaticCoroutineRunner

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (14): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+6 more)

### Community 12 - "Vegetation"
Cohesion: 0.14
Nodes (7): Class, Crunched, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.06
Nodes (18): MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel(), onPointerDown() (+10 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.05
Nodes (6): BufferAttribute, copyAttributeData(), DataUtils, denormalize(), Float16BufferAttribute, InterleavedBufferAttribute

### Community 17 - "BatchedMesh"
Cohesion: 0.07
Nodes (5): ascIdSort(), BatchedMesh, convertBufferAttribute(), copyArrayContents(), sortedArray()

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
Nodes (12): App, fromLatLng(), toLatLng(), esc(), ForgeCard, T(), weatherWord(), windWord() (+4 more)

### Community 23 - "Stats"
Cohesion: 0.09
Nodes (10): What a regression would do on the live server, worst first, DeathWatch, Boss, D, Kit, Spot, Standing, Stats (+2 more)

### Community 24 - "update"
Cohesion: 0.06
Nodes (53): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+45 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.14
Nodes (7): ParticleSystem, ThreeDTests, Chunk, Obj, Rock, WorldObjects, Total

### Community 27 - "WebGLShaderCache"
Cohesion: 0.18
Nodes (9): getMaxPrecision(), WebGLPrograms(), dispose(), getChannel(), getParameters(), getProgramCacheKey(), getProgramCacheKeyBooleans(), getProgramCacheKeyParameters() (+1 more)

### Community 29 - "measure.js"
Cohesion: 0.09
Nodes (14): BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool, MINUTES, reachBands() (+6 more)

### Community 31 - "Features"
Cohesion: 0.07
Nodes (7): Chart, MaskedRev, Feature, Features, Grids, Named, Fnv

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

### Community 37 - "TileMath"
Cohesion: 0.14
Nodes (3): TilesTests, TileMath, ChunksPerSide

### Community 38 - ".constructor"
Cohesion: 0.11
Nodes (28): createCanvasElement(), WebGLAnimation(), onAnimationFrame(), WebGLCubeUVMaps(), dispose(), isCubeTextureComplete(), onTextureDispose(), WebGLMorphtargets() (+20 more)

### Community 40 - "GlbWriter"
Cohesion: 0.14
Nodes (7): GlbWriter, Count, Primitive, Result, GlbWriter, Count, Primitive

### Community 41 - "Kitchen"
Cohesion: 0.05
Nodes (24): Deeds, DeedsGonePatch, DeedsRoutePatch, Kind, Kill, Rock, Tree, Last (+16 more)

### Community 43 - "Kind"
Cohesion: 0.07
Nodes (17): Entry, Kind, Pieces, Peak, Peaks, All, Kind, Runestones (+9 more)

### Community 44 - "leaflet.js"
Cohesion: 0.06
Nodes (47): Ae(), at(), be(), d(), De(), e(), ei(), F() (+39 more)

### Community 45 - "WebXRManager"
Cohesion: 0.10
Nodes (5): WebGLClipping(), projectPlanes(), resetGlobalState(), renderScene(), WebXRManager

### Community 46 - ".applyMatrix4"
Cohesion: 0.04
Nodes (9): Box2, Box3Helper, BoxHelper, checkIntersection(), InstancedBufferAttribute, InstancedMesh, Matrix2, Sphere (+1 more)

### Community 47 - ".Sweep"
Cohesion: 0.07
Nodes (9): Entry, Graves, Demisters, Dungeons, Signature, Inside, Visited, Placed (+1 more)

### Community 48 - "AuthTests"
Cohesion: 0.13
Nodes (3): Auth, Session, AuthTests

### Community 49 - "Regex"
Cohesion: 0.20
Nodes (3): HdMaps, HdMapsTests, Sink

### Community 50 - ".equals"
Cohesion: 0.09
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebXRManager"
Cohesion: 0.08
Nodes (14): WebGLRenderTarget, _createRenderTarget(), WebGLRenderer, renderObject(), renderObjects(), renderTransmissionPass(), VSMPass(), viewport() (+6 more)

### Community 52 - "Vector4"
Cohesion: 0.04
Nodes (4): LightShadow, PointLight, PointLightShadow, Vector4

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "net.js"
Cohesion: 0.06
Nodes (20): ChunkStore, ObjectStore, parseVeg(), RegionLoader, VegStore, RuinsLayer, RuinStore, connect() (+12 more)

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - ".FromSerialized"
Cohesion: 0.25
Nodes (4): MeshExtractor, LastFound, LastReport, Running

### Community 57 - "Matrix4"
Cohesion: 0.05
Nodes (7): AxesHelper, Bone, CatmullRomCurve3, flattenJSON(), Matrix4, getTexture(), Skeleton

### Community 58 - "Color"
Cohesion: 0.08
Nodes (5): Color, createColorManagement(), hue2rgb(), LinearToSRGB(), SRGBToLinear()

### Community 61 - "Fact"
Cohesion: 0.11
Nodes (4): GateTests, SettingsTests, StatsTests, VersionTests

### Community 62 - "TileStore"
Cohesion: 0.11
Nodes (7): TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered, RenderMsTotal

### Community 63 - "markercanvas.js"
Cohesion: 0.11
Nodes (12): asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache, labelImage() (+4 more)

### Community 64 - ".ReadConfigFile"
Cohesion: 0.11
Nodes (3): WebMapConfig, HeightMaxZoom, LightModeTests

### Community 65 - "push"
Cohesion: 0.07
Nodes (29): cloneUniforms(), ExternalTexture, getUnlitUniformColorSpace(), mergeUniforms(), shadowCastingAndTexturingLightsFirst(), WebGLBackground(), addToRenderList(), dispose() (+21 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.10
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Func"
Cohesion: 0.05
Nodes (15): Body, ChatRelay, Discord, Token, DiscordMessage, DiscordRef, Result, Entry (+7 more)

### Community 70 - "TileJob"
Cohesion: 0.12
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 71 - ".clone"
Cohesion: 0.03
Nodes (18): Curve, CurvePath, DirectionalLight, addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces() (+10 more)

### Community 72 - "PMREMGenerator"
Cohesion: 0.18
Nodes (4): Mesh, PMREMGenerator, _setViewport(), get()

### Community 73 - ".parseObject"
Cohesion: 0.05
Nodes (24): AnimationLoader, AudioLoader, handleError(), BufferGeometryLoader, getArrayBuffer(), getInterleavedBuffer(), CompressedTextureLoader, loadTexture() (+16 more)

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
Cohesion: 0.10
Nodes (9): Coming from WebMap, Install, BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, QuaternionKeyframeTrack, StringKeyframeTrack, subclip() (+1 more)

### Community 79 - "Items"
Cohesion: 0.12
Nodes (4): Items, Ready, ItemsTests, WithDir

### Community 80 - "MapDataServer"
Cohesion: 0.06
Nodes (5): Snap, MapDataServer, PlayersWs, MapMessage, WebSocketHandler

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "TextureExtractor"
Cohesion: 0.14
Nodes (6): At, Source, TextureExtractor, LastFound, LastReport, Running

### Community 83 - "Layers"
Cohesion: 0.12
Nodes (5): 2.9.1, ascSort(), intersect(), Layers, Raycaster

### Community 86 - "BundleFile"
Cohesion: 0.14
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 87 - "TreesGL"
Cohesion: 0.22
Nodes (3): drawPicture(), renderTarget(), ShapeCache

### Community 88 - ".FromSerialized"
Cohesion: 0.16
Nodes (6): TextureExtractor, LastFound, LastReport, Running, Bits, TextureDecoder

### Community 89 - "SerializedFile"
Cohesion: 0.18
Nodes (8): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode, TypeInfo

### Community 90 - "GLTFParser"
Cohesion: 0.20
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.09
Nodes (7): Testing, FeaturesTests, PiecesTests, PortalsTests, Grid, Cell, J

### Community 93 - "BuildingsGL"
Cohesion: 0.08
Nodes (7): BuildingsGL, hexRgb(), materialRgb(), PackedRegions, packRects(), RECT_LAYOUT(), RuinsGL

### Community 95 - "Activity"
Cohesion: 0.26
Nodes (3): Activity, Trail, ActivityTests

### Community 96 - "web/js/view3d.js"
Cohesion: 0.11
Nodes (14): _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), facing(), fallbackColor() (+6 more)

### Community 97 - "get"
Cohesion: 0.09
Nodes (65): createElementNS(), WebGLCapabilities(), getMaxAnisotropy(), textureFormatReadable(), textureTypeReadable(), WebGLCubeMaps(), get(), mapTextureMapping() (+57 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.11
Nodes (23): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+15 more)

### Community 99 - "BundleFile"
Cohesion: 0.18
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "ModelStore"
Cohesion: 0.10
Nodes (14): Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted, PrefabsJson, QueueLength (+6 more)

### Community 103 - "BiomeMap"
Cohesion: 0.13
Nodes (4): BiomeMap, Label, Now, Weather

### Community 104 - "TerrainPatches"
Cohesion: 0.11
Nodes (8): Heights, KeepSamples, Job, Served, Patch, TerrainPatches, Count, Job

### Community 105 - "Using the map"
Cohesion: 0.11
Nodes (18): Chat commands, Checking the viewer against a live server, Configuration, Discord, Features, Full-quality textures (optional), Licence and credit, Local test server (+10 more)

### Community 106 - "Regex"
Cohesion: 0.27
Nodes (4): Data, MeshCache, Data, MeshCache

### Community 109 - "RaidLayer"
Cohesion: 0.18
Nodes (5): MapCore, ago(), areaCache, areaImage(), RaidLayer

### Community 110 - ".FromSerialized"
Cohesion: 0.19
Nodes (6): MeshExtractor, LastFound, LastReport, Running, Decoded, MeshDecoder

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.21
Nodes (4): GroundGL, perSide(), span(), screenArea()

### Community 113 - "Texture"
Cohesion: 0.03
Nodes (18): CanvasTexture, CompressedArrayTexture, CompressedCubeTexture, CompressedTexture, CubeTexture, Data3DTexture, DataArrayTexture, DepthTexture (+10 more)

### Community 114 - "Changelog"
Cohesion: 0.12
Nodes (15): 2.11.0, 2.14.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog (+7 more)

### Community 115 - "Feed"
Cohesion: 0.20
Nodes (6): Ev, Feed, Keep, RecentJson, FeedTests, SkipToMorningPatch

### Community 117 - "Structures"
Cohesion: 0.05
Nodes (19): Regions, Chunk, Ruins, IndexJson, LastChanged, Total, Site, Base (+11 more)

### Community 118 - "arraysEqual"
Cohesion: 0.21
Nodes (19): allocTexUnits(), arraysEqual(), copyArray(), setValueM2(), setValueM3(), setValueM4(), setValueT1Array(), setValueT2DArrayArray() (+11 more)

### Community 119 - ".LookJson"
Cohesion: 0.11
Nodes (7): Item, Joints, Look, Rig, RigTests, Hotspots, Json

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 122 - "Dictionary"
Cohesion: 0.17
Nodes (4): HotspotsTests, BuildHistory, Snap, JsonParser

### Community 124 - "Interpolant"
Cohesion: 0.17
Nodes (4): CubicInterpolant, DiscreteInterpolant, Interpolant, LinearInterpolant

### Community 126 - "Entry"
Cohesion: 0.10
Nodes (12): Entry, ItemIcons, Dir, Entry, MapIcons, Dir, Format, Gray16 (+4 more)

### Community 127 - "ContourGL"
Cohesion: 0.14
Nodes (3): ContourGL, labelImage(), span()

### Community 128 - ".load"
Cohesion: 0.14
Nodes (5): getImageURIMimeType(), GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension, LoaderUtils

### Community 129 - "AnimationClip"
Cohesion: 0.11
Nodes (5): AnimationClip, AnimationUtils, getTrackTypeForValueTypeName(), NumberKeyframeTrack, parseKeyframeTrack()

### Community 131 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 133 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - "Light"
Cohesion: 0.11
Nodes (5): AmbientLight, HemisphereLight, Light, LightProbe, RectAreaLight

### Community 138 - "Français"
Cohesion: 0.12
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 140 - "PerspectiveCamera"
Cohesion: 0.09
Nodes (5): ArrayCamera, PerspectiveCamera, SpotLight, SpotLightShadow, StereoCamera

### Community 141 - "i18n.js"
Cohesion: 0.17
Nodes (7): Gear, fill(), has(), num(), t(), tn(), translateTree()

### Community 143 - "Portals"
Cohesion: 0.27
Nodes (3): Entry, Last, Portals

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 146 - ".getContext"
Cohesion: 0.29
Nodes (3): AudioContext, ImageUtils, serializeImage()

### Community 148 - "WebMap"
Cohesion: 0.07
Nodes (9): Announce, Token, Pending, DiscordWebHook, StaticCoroutine, WebMap, ZNetPatchSetServer, ZoneSystemLoadPatch (+1 more)

### Community 151 - "check.mjs"
Cohesion: 0.17
Nodes (17): 2.15.0, HTTP endpoints, [BASE, PORT, OUT], check(), map(), open(), plan(), players() (+9 more)

### Community 153 - "Cat"
Cohesion: 0.29
Nodes (7): Cat, Bush, Other, Piece, Rock, Skip, Tree

### Community 154 - "bench.mjs"
Cohesion: 0.20
Nodes (10): 2.12.0, [BASE, PORT], errors, ev(), ms(), pending, send(), tab (+2 more)

### Community 159 - "SmoothZoom"
Cohesion: 0.32
Nodes (3): SmoothZoom, SmoothZoomControl, update()

### Community 160 - "vegpack.js"
Cohesion: 0.23
Nodes (10): packTrees(), radiusOf(), RGB, seedOf(), SMALL_R, TREE_STRIDE, unpackRegion(), VEG (+2 more)

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 164 - "bi"
Cohesion: 0.33
Nodes (6): ForgeMap 1.2.0, bi(), Pi(), q(), Ti(), u()

### Community 166 - "MeshDecoder"
Cohesion: 0.25
Nodes (3): Decoded, MeshDecoder, P

### Community 167 - "FogMask"
Cohesion: 0.20
Nodes (3): FogMask, Kept, WorldPicture

### Community 169 - "BiomeGL"
Cohesion: 0.24
Nodes (3): 2.13.0, bigText(), BiomeGL

### Community 171 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 172 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

### Community 173 - "ServerLog"
Cohesion: 0.22
Nodes (4): Line, ServerLog, ChunkCache, Line

### Community 174 - "oi"
Cohesion: 0.67
Nodes (4): Je(), ni(), oi(), si()

### Community 175 - "IEnumerator"
Cohesion: 0.14
Nodes (6): ZNetPatchDisconnect, ZNetPatchStart, ZRoutedRpcAddPeerPatch, WorldEvents, InvasionsPath, StatePath

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

### Community 186 - "WebGLState"
Cohesion: 0.20
Nodes (17): WebGLState(), ColorBuffer(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), reset(), scissor() (+9 more)

### Community 190 - "LocationTerrain"
Cohesion: 0.23
Nodes (4): LocationTerrain, Count, Mod, Patch

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 197 - "WebGLMaterials"
Cohesion: 0.16
Nodes (21): WebGLMaterials(), refreshFogUniforms(), refreshMaterialUniforms(), refreshTransformUniform(), refreshUniformsCommon(), refreshUniformsDash(), refreshUniformsDistance(), refreshUniformsLine() (+13 more)

### Community 200 - "playercard.js"
Cohesion: 0.08
Nodes (36): PlayerCard, activityHtml(), ARMOR_SLOTS, at(), BIOME_COL, clock(), connHtml(), day() (+28 more)

### Community 201 - "EventDispatcher"
Cohesion: 0.07
Nodes (8): EventDispatcher, handleVisibilityChange(), ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), LoadingManager, Timer

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 205 - "system_io"
Cohesion: 0.10
Nodes (6): WebMap.Models.Unity, WebMap.Util, WebMap.MuninModels, WebMap.MuninModels.Unity, WebMap.Models, WebMap.Tiles

### Community 209 - "ShaderMaterial"
Cohesion: 0.14
Nodes (9): BoxGeometry, cloneUniformsGroups(), RawShaderMaterial, ShaderMaterial, WebGLCubeRenderTarget, _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial() (+1 more)

### Community 215 - "SerializedFile"
Cohesion: 0.18
Nodes (6): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeNode

### Community 222 - "Kind"
Cohesion: 0.25
Nodes (8): Kind, Chest, Gate, Generator, Mining, Monster, None, Pickable

### Community 223 - "Window"
Cohesion: 0.27
Nodes (3): Ping, Window, PingTests

### Community 232 - "Line"
Cohesion: 0.08
Nodes (8): ArrowHelper, ConeGeometry, CylinderGeometry, Line, MeshBasicMaterial, PlaneHelper, PointLightHelper, SphereGeometry

## Knowledge Gaps
- **246 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+241 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1972 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **68 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `Func`, `HashSet`, `Kitchen`, `TerrainPatches`, `Kind`, `EventDispatcher`, `Portals`, `AuthTests`, `MapDataServer`, `Changelog`, `WebMap`, `WorldObjects`, `Fact`, `View3D`, `Fact`, `Features`?**
  _High betweenness centrality (0.391) - this node is a cross-community bridge._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _246 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.0073177455329173245 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `EventDispatcher` to `three.core.js`, `three.module.js`, `Stats`?**
  _High betweenness centrality (0.325) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007644007644007644 - nodes in this community are weakly interconnected._
- **Why does `View3D` connect `View3D` to `web/js/view3d.js`, `web/js/sky.js`, `RigBuilder`?**
  _High betweenness centrality (0.088) - this node is a cross-community bridge._
- **Should `.push` be split into smaller, more focused modules?**
  _Cohesion score 0.029153766769865842 - nodes in this community are weakly interconnected._