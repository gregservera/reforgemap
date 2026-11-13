# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 229 files · ~728,968 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6906 nodes · 16828 edges · 221 communities (156 shown, 65 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 876 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `9fda0675`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- three.core.js
- three.module.js
- .push
- app.js
- .copy
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
- Fog
- BatchedMesh
- Markers
- markers.js
- Dictionary
- .start
- unityengine
- Stats
- update
- textures-hd.py
- WorldObjects
- get
- View3D
- measure.js
- system_collections_generic
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
- Kitchen
- JsonWriter
- List
- leaflet.js
- WebXRManager
- .applyMatrix4
- .Sweep
- AuthTests
- Mesh
- .equals
- WebXRManager
- Vector4
- Veg
- net.js
- PropertyBinding
- Func
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
- RaidLayer
- Activity
- web/js/view3d.js
- uploadTexture
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
- toLatLng
- Dictionary
- Hand
- GroundGL
- Texture
- Changelog
- Feed
- LocationTerrain
- Structures
- arraysEqual
- .LookJson
- map-core.test.mjs
- Locations
- _points
- system_io
- Interpolant
- Vehicles
- ContourGL
- .load
- AnimationClip
- .Export
- particles.js
- Fact
- MigrationTests
- .constructor
- TextureDecoder
- BufferGeometryUtils.js
- .clone
- Français
- ItemIcons
- JsonParser
- i18n.js
- QuadraticBezierCurve
- Portals
- PolyhedronGeometry
- InterleavedBuffer
- Layers
- Transform
- WebMap
- AltBiomeGL
- CompressedTexture
- check.mjs
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
- Window
- addToRenderList
- VideoTexture
- addShape
- WebP
- WebGLState
- BiomeGL
- Preview
- fetchTerrarium
- GuideGL
- .NewWorld
- m
- IEnumerator
- MuninConfig
- EllipseCurve
- Material
- WebGLShaderCache
- WebMap.Tests.csproj
- WebMap.csproj
- Shape
- Spherical
- render
- FogGL
- GLTFMaterialsDispersionExtension
- Cylindrical
- GLBufferAttribute
- StaticFilesTests
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- k
- Primitive
- CubicBezierCurve
- MeshPhysicalMaterial
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- CubicBezierCurve3
- FogExp2
- InstancedBufferGeometry
- bi
- Third-party notices
- system
- .load
- TextureUtils
- testserver.sh
- MultiDrawRenderList
- Uniform
- layers.js
- SerializedFile
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

## Communities (221 total, 65 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (236): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+228 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (72): _cache, InterpolationSamplingMode, InterpolationSamplingType, MathUtils, TimestampQuery, TOUCH, UniformsUtils, arrayCacheF32 (+64 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (47): ArrowHelper, AxesHelper, Box3Helper, BoxGeometry, buildPlane(), BufferGeometry, CameraHelper, addLine() (+39 more)

### Community 3 - "app.js"
Cohesion: 0.05
Nodes (83): chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM, TILE (+75 more)

### Community 4 - ".copy"
Cohesion: 0.04
Nodes (15): a(), c(), handleTriangle(), handleVertex(), checkGeometryIntersection(), checkIntersection$1(), Frustum, isUniqueEdge() (+7 more)

### Community 5 - "WebXRController"
Cohesion: 0.09
Nodes (4): Group, Scene, UniformsGroup, WebXRController

### Community 6 - "Vector3"
Cohesion: 0.03
Nodes (14): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+6 more)

### Community 7 - "Object3D"
Cohesion: 0.03
Nodes (9): Bone, Camera, CubeCamera, DirectionalLightShadow, Matrix4, Object3D, OrthographicCamera, Skeleton (+1 more)

### Community 8 - "HashSet"
Cohesion: 0.06
Nodes (16): Chart, Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump (+8 more)

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (58): iconSvg(), byName(), makeIcon(), statsHtml(), BIOME_SVG, breakable(), BUILD_SVG, BUSH_SVG (+50 more)

### Community 10 - "Part"
Cohesion: 0.17
Nodes (6): GlbWriter, Count, Node, Primitive, Skin, Part

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (15): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+7 more)

### Community 12 - "Vegetation"
Cohesion: 0.11
Nodes (7): Class, Crunched, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.06
Nodes (18): MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel(), onPointerDown() (+10 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.06
Nodes (8): BufferAttribute, convertBufferAttribute(), copyArrayContents(), createColorManagement(), DataUtils, denormalize(), Float16BufferAttribute, sortedArray()

### Community 17 - "BatchedMesh"
Cohesion: 0.04
Nodes (11): ascIdSort(), BatchedMesh, CatmullRomCurve3, cloneUniformsGroups(), copyAttributeData(), flattenJSON(), InstancedBufferAttribute, InstancedMesh (+3 more)

### Community 18 - "Markers"
Cohesion: 0.06
Nodes (12): BaseOverride, BedSpot, Findable, Markers, Json, Rev, PartTimer, Portal (+4 more)

### Community 19 - "markers.js"
Cohesion: 0.07
Nodes (25): MapCore, adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), collator (+17 more)

### Community 20 - "Dictionary"
Cohesion: 0.08
Nodes (16): Libraries, PrefabsJson, Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted (+8 more)

### Community 21 - ".start"
Cohesion: 0.08
Nodes (8): App, BiomeHover, fromLatLng(), esc(), ForgeCard, T(), weatherWord(), windWord()

### Community 23 - "Stats"
Cohesion: 0.09
Nodes (10): What a regression would do on the live server, worst first, DeathWatch, Boss, D, Kit, Spot, Standing, Stats (+2 more)

### Community 24 - "update"
Cohesion: 0.05
Nodes (55): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+47 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.09
Nodes (16): MapFog, Revision, ParticleSystem, ThreeDTests, Cat, Bush, Other, Piece (+8 more)

### Community 27 - "get"
Cohesion: 0.12
Nodes (40): renderTarget(), WebGLCapabilities(), getMaxAnisotropy(), textureFormatReadable(), textureTypeReadable(), WebGLCubeMaps(), get(), mapTextureMapping() (+32 more)

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

### Community 37 - "Sphere"
Cohesion: 0.06
Nodes (5): ascSort(), Box2, BoxHelper, Raycaster, Sphere

### Community 38 - ".constructor"
Cohesion: 0.14
Nodes (24): WebGLMaterials(), refreshFogUniforms(), refreshMaterialUniforms(), refreshTransformUniform(), refreshUniformsCommon(), refreshUniformsDash(), refreshUniformsDistance(), refreshUniformsLine() (+16 more)

### Community 40 - "playercard.js"
Cohesion: 0.10
Nodes (32): activityHtml(), ARMOR_SLOTS, at(), BIOME_COL, clock(), connHtml(), day(), dayLabel() (+24 more)

### Community 41 - "Kitchen"
Cohesion: 0.06
Nodes (23): Deeds, DeedsGonePatch, DeedsRoutePatch, Kind, Kill, Rock, Tree, Last (+15 more)

### Community 43 - "List"
Cohesion: 0.09
Nodes (10): Kind, Table, Peak, Peaks, All, Kind, Runestones, Stone (+2 more)

### Community 44 - "leaflet.js"
Cohesion: 0.06
Nodes (32): Ae(), at(), be(), Ci(), d(), De(), ei(), ht() (+24 more)

### Community 45 - "WebXRManager"
Cohesion: 0.08
Nodes (11): WebGLAnimation(), onAnimationFrame(), onAnimationFrame(), WebXRDepthSensing, WebXRManager, onInputSourcesChange(), onSessionEnd(), onSessionEvent() (+3 more)

### Community 46 - ".applyMatrix4"
Cohesion: 0.07
Nodes (3): checkIntersection(), FrustumArray, InterleavedBufferAttribute

### Community 47 - ".Sweep"
Cohesion: 0.06
Nodes (18): Entry, Graves, Demisters, Dungeons, Signature, Inside, Visited, Kind (+10 more)

### Community 48 - "AuthTests"
Cohesion: 0.15
Nodes (3): Auth, Session, AuthTests

### Community 49 - "Mesh"
Cohesion: 0.15
Nodes (4): Mesh, PlaneGeometry, PointLightHelper, SphereGeometry

### Community 50 - ".equals"
Cohesion: 0.07
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebXRManager"
Cohesion: 0.09
Nodes (8): WebGLCubeRenderTarget, WebGLRenderTarget, getMaxPrecision(), getChannel(), getParameters(), WebGLRenderer, renderTransmissionPass(), VSMPass()

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "net.js"
Cohesion: 0.06
Nodes (11): ChunkStore, ObjectStore, parseVeg(), RegionLoader, VegStore, FogLayer, RuinsLayer, RuinStore (+3 more)

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "Func"
Cohesion: 0.13
Nodes (6): Entry, Given, Settings, Live, Stats, WorldEvents

### Community 57 - "Light"
Cohesion: 0.11
Nodes (5): AmbientLight, HemisphereLight, Light, LightProbe, RectAreaLight

### Community 58 - "Color"
Cohesion: 0.08
Nodes (4): Color, hue2rgb(), LinearToSRGB(), SRGBToLinear()

### Community 60 - "Box3"
Cohesion: 0.08
Nodes (3): Box3, satForAxes(), SkinnedMesh

### Community 61 - "GateTests"
Cohesion: 0.09
Nodes (4): WebMapConfig, HeightMaxZoom, GateTests, LightModeTests

### Community 62 - "TileStore"
Cohesion: 0.08
Nodes (9): TileMath, ChunksPerSide, TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered (+1 more)

### Community 63 - "markercanvas.js"
Cohesion: 0.10
Nodes (13): colors, asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache (+5 more)

### Community 64 - "Euler"
Cohesion: 0.09
Nodes (5): Euler, MeshLambertMaterial, MeshPhongMaterial, onQuaternionChange(), onRotationChange()

### Community 65 - "push"
Cohesion: 0.08
Nodes (26): ExternalTexture, WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights(), setup(), setupView(), WebGLPrograms() (+18 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.10
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Func"
Cohesion: 0.09
Nodes (9): Body, ChatRelay, Discord, Token, DiscordMessage, DiscordRef, Result, ChatRelayTests (+1 more)

### Community 70 - "TileJob"
Cohesion: 0.12
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 71 - "Curve"
Cohesion: 0.09
Nodes (3): Curve, LineCurve, LineCurve3

### Community 72 - "PMREMGenerator"
Cohesion: 0.13
Nodes (12): ShaderMaterial, _createRenderTarget(), _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial(), PMREMGenerator, _setViewport() (+4 more)

### Community 73 - "Loader"
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
Nodes (7): GLTFLoader, GLTFMaterialsBumpExtension, GLTFMaterialsEmissiveStrengthExtension, GLTFMaterialsIorExtension, GLTFMaterialsIridescenceExtension, GLTFMeshGpuInstancing, GLTFMeshoptCompression

### Community 78 - "KeyframeTrack"
Cohesion: 0.09
Nodes (7): BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, LinearInterpolant, QuaternionKeyframeTrack, StringKeyframeTrack, VectorKeyframeTrack

### Community 79 - "Items"
Cohesion: 0.12
Nodes (3): Items, Ready, ItemsTests

### Community 80 - "MapDataServer"
Cohesion: 0.08
Nodes (5): Snap, MapDataServer, PlayersWs, MapMessage, WebSocketHandler

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "TextureExtractor"
Cohesion: 0.10
Nodes (10): MeshExtractor, LastFound, LastReport, Running, At, Source, TextureExtractor, LastFound (+2 more)

### Community 83 - "LoadingManager"
Cohesion: 0.07
Nodes (8): EventDispatcher, handleVisibilityChange(), ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), LoadingManager, Timer

### Community 86 - "BundleFile"
Cohesion: 0.16
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 88 - "HashSet"
Cohesion: 0.12
Nodes (8): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running

### Community 89 - "SerializedFile"
Cohesion: 0.16
Nodes (8): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode, TypeInfo

### Community 90 - "GLTFParser"
Cohesion: 0.20
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.12
Nodes (5): FeaturesTests, PiecesTests, Grid, Cell, J

### Community 92 - "ShapesCanvas"
Cohesion: 0.18
Nodes (3): compile(), drawPicture(), ShapesCanvas

### Community 93 - "BuildingsGL"
Cohesion: 0.10
Nodes (5): BuildingsGL, PackedRegions, packRects(), RECT_LAYOUT(), RuinsGL

### Community 94 - "RaidLayer"
Cohesion: 0.23
Nodes (3): ago(), areaImage(), RaidLayer

### Community 95 - "Activity"
Cohesion: 0.26
Nodes (3): Activity, Trail, ActivityTests

### Community 96 - "web/js/view3d.js"
Cohesion: 0.13
Nodes (13): Street, _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), fallbackColor() (+5 more)

### Community 97 - "uploadTexture"
Cohesion: 0.15
Nodes (28): activeTexture(), bindTexture(), compressedTexImage2D(), compressedTexImage3D(), compressedTexSubImage2D(), compressedTexSubImage3D(), createTexture(), texImage2D() (+20 more)

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
Cohesion: 0.10
Nodes (14): Info, ModelStore, Exported, Hashes, MeshesPresent, MeshesWanted, PrefabsJson, QueueLength (+6 more)

### Community 104 - "TerrainPatches"
Cohesion: 0.11
Nodes (8): Heights, KeepSamples, Job, Served, Patch, TerrainPatches, Count, Job

### Community 105 - "Using the map"
Cohesion: 0.10
Nodes (20): Chat commands, Checking the viewer against a live server, Coming from WebMap, Configuration, Discord, Features, Full-quality textures (optional), Install (+12 more)

### Community 106 - "Regex"
Cohesion: 0.10
Nodes (9): HdMaps, Data, MeshCache, GlbWriter, Count, Primitive, Data, MeshCache (+1 more)

### Community 109 - "toLatLng"
Cohesion: 0.17
Nodes (5): PlayerCard, toLatLng(), escape(), PALETTE, PlayersLayer

### Community 110 - "Dictionary"
Cohesion: 0.16
Nodes (5): Decoded, MeshDecoder, Decoded, MeshDecoder, P

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.21
Nodes (4): GroundGL, perSide(), span(), screenArea()

### Community 113 - "Texture"
Cohesion: 0.05
Nodes (13): CanvasTexture, CubeTexture, Data3DTexture, DataArrayTexture, DepthTexture, FramebufferTexture, RenderTarget, RenderTarget3D (+5 more)

### Community 114 - "Changelog"
Cohesion: 0.10
Nodes (19): 2.10.0, 2.11.0, 2.14.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0 (+11 more)

### Community 115 - "Feed"
Cohesion: 0.20
Nodes (6): Ev, Feed, Keep, RecentJson, FeedTests, SkipToMorningPatch

### Community 116 - "LocationTerrain"
Cohesion: 0.21
Nodes (4): LocationTerrain, Count, Mod, Patch

### Community 117 - "Structures"
Cohesion: 0.05
Nodes (21): ChunkCache, Line, Regions, Chunk, Ruins, IndexJson, LastChanged, Total (+13 more)

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
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 124 - "Interpolant"
Cohesion: 0.18
Nodes (3): CubicInterpolant, DiscreteInterpolant, Interpolant

### Community 126 - "Vehicles"
Cohesion: 0.13
Nodes (7): Entry, Traders, Kind, Boat, Cart, None, Vehicles

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

### Community 132 - "Fact"
Cohesion: 0.08
Nodes (7): HdMapsTests, PinsTests, File_, SettingsTests, WithDir, StatsTests, TilesTests

### Community 133 - "MigrationTests"
Cohesion: 0.14
Nodes (7): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins, VersionTests

### Community 134 - ".constructor"
Cohesion: 0.13
Nodes (23): createCanvasElement(), createElementNS(), dispose(), dispose(), deallocateMaterial(), getContext(), getProgram(), materialNeedsLights() (+15 more)

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - ".clone"
Cohesion: 0.04
Nodes (13): ArrayCamera, DirectionalLight, LightShadow, LineLoop, LOD, getMaterial(), getTexture(), PerspectiveCamera (+5 more)

### Community 138 - "Français"
Cohesion: 0.12
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 139 - "ItemIcons"
Cohesion: 0.09
Nodes (13): 2.12.0, Entry, ItemIcons, Dir, Entry, MapIcons, Dir, Format (+5 more)

### Community 140 - "JsonParser"
Cohesion: 0.13
Nodes (6): HotspotsTests, BuildHistory, Snap, Hotspots, Json, JsonParser

### Community 141 - "i18n.js"
Cohesion: 0.17
Nodes (7): Gear, fill(), has(), num(), t(), tn(), translateTree()

### Community 142 - "QuadraticBezierCurve"
Cohesion: 0.12
Nodes (6): QuadraticBezier(), QuadraticBezierCurve, QuadraticBezierCurve3, QuadraticBezierP0(), QuadraticBezierP1(), QuadraticBezierP2()

### Community 143 - "Portals"
Cohesion: 0.21
Nodes (5): Testing, Entry, Last, Portals, PortalsTests

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 145 - "InterleavedBuffer"
Cohesion: 0.11
Nodes (5): getArrayBuffer(), getInterleavedBuffer(), generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer

### Community 146 - "Layers"
Cohesion: 0.07
Nodes (8): 2.9.1, AudioContext, AudioListener, Clock, ImageUtils, intersect(), Layers, StereoCamera

### Community 148 - "WebMap"
Cohesion: 0.05
Nodes (13): Announce, Token, Pending, DiscordWebHook, StaticCoroutine, StaticCoroutineRunner, WebMap, ZNetPatchDisconnect (+5 more)

### Community 150 - "CompressedTexture"
Cohesion: 0.25
Nodes (3): CompressedArrayTexture, CompressedCubeTexture, CompressedTexture

### Community 151 - "check.mjs"
Cohesion: 0.32
Nodes (11): [BASE, PORT, OUT], check(), map(), open(), plan(), players(), portals(), sleep() (+3 more)

### Community 153 - "parseUniform"
Cohesion: 0.17
Nodes (7): addUniform(), getPureArraySetter(), getSingularSetter(), parseUniform(), PureArrayUniform, SingleUniform, StructuredUniform

### Community 154 - "bench.mjs"
Cohesion: 0.24
Nodes (9): [BASE, PORT], errors, ev(), ms(), pending, send(), tab, views (+1 more)

### Community 158 - "FallbackTileLayer"
Cohesion: 0.08
Nodes (5): StructuresLayer, FallbackTileLayer, zoomOutPixelBounds(), shade(), VegLayer

### Community 159 - "SmoothZoom"
Cohesion: 0.36
Nodes (3): SmoothZoom, SmoothZoomControl, update()

### Community 160 - "vegpack.js"
Cohesion: 0.23
Nodes (10): packTrees(), radiusOf(), RGB, seedOf(), SMALL_R, TREE_STRIDE, unpackRegion(), VEG (+2 more)

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 163 - "Window"
Cohesion: 0.27
Nodes (3): Ping, Window, PingTests

### Community 164 - "addToRenderList"
Cohesion: 0.31
Nodes (8): cloneUniforms(), getUnlitUniformColorSpace(), mergeUniforms(), WebGLBackground(), addToRenderList(), getBackground(), render(), setClear()

### Community 166 - "addShape"
Cohesion: 0.27
Nodes (11): addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3(), f4(), getBevelVec() (+3 more)

### Community 167 - "WebP"
Cohesion: 0.19
Nodes (3): WorldPicture, WebP, Enabled

### Community 168 - "WebGLState"
Cohesion: 0.22
Nodes (17): renderScene(), WebGLState(), ColorBuffer(), DepthBuffer(), disable(), enable(), reset(), scissor() (+9 more)

### Community 169 - "BiomeGL"
Cohesion: 0.24
Nodes (3): 2.13.0, bigText(), BiomeGL

### Community 171 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 172 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

### Community 173 - ".NewWorld"
Cohesion: 0.11
Nodes (5): ImageConv, Line, ServerLog, Trails, ZNetPatchShutdown

### Community 174 - "m"
Cohesion: 0.36
Nodes (8): e(), hi(), m(), Qe(), ve(), xe(), ye(), z()

### Community 175 - "IEnumerator"
Cohesion: 0.19
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
Cohesion: 0.22
Nodes (13): F(), G(), h(), j(), k(), ke(), me(), ne() (+5 more)

### Community 203 - "bi"
Cohesion: 0.33
Nodes (6): ForgeMap 1.2.0, bi(), Pi(), q(), Ti(), u()

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 205 - "system"
Cohesion: 0.12
Nodes (3): WebMap.Models.Unity, WebMap.MuninModels, WebMap.MuninModels.Unity

### Community 215 - "SerializedFile"
Cohesion: 0.18
Nodes (6): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeNode

## Knowledge Gaps
- **245 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+240 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1952 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **65 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `Func`, `Fact`, `HashSet`, `Kitchen`, `TerrainPatches`, `.NewWorld`, `Portals`, `AuthTests`, `MapDataServer`, `Changelog`, `LoadingManager`, `WebMap`, `WorldObjects`, `View3D`, `Features`?**
  _High betweenness centrality (0.393) - this node is a cross-community bridge._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _245 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007295373665480427 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `LoadingManager` to `three.core.js`, `three.module.js`, `Stats`?**
  _High betweenness centrality (0.328) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007888319315184392 - nodes in this community are weakly interconnected._
- **Why does `View3D` connect `View3D` to `web/js/view3d.js`, `web/js/sky.js`, `.canopyMaterial`?**
  _High betweenness centrality (0.090) - this node is a cross-community bridge._
- **Should `.push` be split into smaller, more focused modules?**
  _Cohesion score 0.026090169992609016 - nodes in this community are weakly interconnected._