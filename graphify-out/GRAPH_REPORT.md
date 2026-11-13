# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 222 files · ~720,219 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6803 nodes · 16514 edges · 211 communities (144 shown, 67 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 845 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `3c0993df`
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
- .clone
- HashSet
- ui.js
- .Export
- View3D
- Vegetation
- OrbitControls
- BufferAttribute
- xunit
- .parseObject
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
- .applyMatrix4
- .constructor
- Vector2
- playercard.js
- Kitchen
- JsonWriter
- List
- leaflet.js
- WebXRManager
- WebXRController
- .Sweep
- AuthTests
- Mesh
- .equals
- WebXRManager
- Vector4
- Veg
- RuinsLayer
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
- Box2
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
- TileMath
- WebGLBindingStates
- BundleFile
- package.json
- AudioListener
- Path
- BiomeMap
- Heights
- Using the map
- Pieces
- PropertyMixer
- particles.js
- toLatLng
- Dictionary
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
- CurvePath
- system_io
- Interpolant
- FogLayer
- ContourGL
- .load
- AnimationClip
- CubicBezierCurve
- Shape
- Fact
- MeshCache
- .constructor
- TextureDecoder
- BufferGeometryUtils.js
- .clone
- QuadraticBezierCurve
- Png
- Français
- i18n.js
- BuildHistory
- Portals
- PolyhedronGeometry
- InterleavedBuffer
- Layers
- LineCurve3
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
- CylinderGeometry
- .parse
- CubicBezierCurve3
- Window
- LineCurve
- VideoTexture
- QuadraticBezierCurve3
- WebP
- WebGLState
- oi
- Preview
- fetchTerrarium
- Setup
- WebMap
- EllipseCurve
- Material
- Spherical
- WebMap.Tests.csproj
- WebMap.csproj
- render
- GLTFMaterialsDispersionExtension
- Cylindrical
- GLBufferAttribute
- FogExp2
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- k
- Texture2D
- MeshPhysicalMaterial
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- bi
- Third-party notices
- system
- .load
- vegpack.js
- TextureUtils
- testserver.sh
- MultiDrawRenderList
- Uniform
- layers.js
- SerializedFile
- GuideGL
- worldkeys.js

## God Nodes (most connected - your core abstractions)
1. `Vector3` - 114 edges
2. `Vector2` - 89 edges
3. `get()` - 88 edges
4. `MapDataServer` - 76 edges
5. `View3D` - 75 edges
6. `Markers` - 73 edges
7. `Object3D` - 70 edges
8. `BufferGeometry` - 69 edges
9. `Vector4` - 66 edges
10. `JsonWriter` - 62 edges

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

## Communities (211 total, 67 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (242): _addedEvent, _alignedPosition, ArrayCamera, _axis, _basePosition, _batchIntersects, _boneMatrix, _box (+234 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (72): _cache, ColorManagement, DefaultLoadingManager, InterpolationSamplingMode, TimestampQuery, UniformsUtils, arrayCacheF32, arrayCacheI32 (+64 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (46): addContour(), Box3Helper, buildPlane(), BoxHelper, BufferGeometry, addLine(), addPoint(), CapsuleGeometry (+38 more)

### Community 3 - "app.js"
Cohesion: 0.03
Nodes (94): 2.13.0, chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM (+86 more)

### Community 4 - ".copy"
Cohesion: 0.05
Nodes (12): a(), c(), handleTriangle(), handleVertex(), checkGeometryIntersection(), checkIntersection$1(), isUniqueEdge(), Line3 (+4 more)

### Community 5 - "Object3D"
Cohesion: 0.03
Nodes (7): CubeCamera, FrustumArray, LOD, Matrix4, Object3D, _points, Sprite

### Community 6 - "Vector3"
Cohesion: 0.03
Nodes (14): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+6 more)

### Community 7 - ".clone"
Cohesion: 0.05
Nodes (12): AxesHelper, Bone, CatmullRomCurve3, cloneUniformsGroups(), scalePt2(), flattenJSON(), InstancedBufferAttribute, InstancedMesh (+4 more)

### Community 8 - "HashSet"
Cohesion: 0.08
Nodes (11): Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump, Tree (+3 more)

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (58): iconSvg(), escape(), makeIcon(), statsHtml(), BIOME_SVG, breakable(), BUILD_SVG, BUSH_SVG (+50 more)

### Community 10 - ".Export"
Cohesion: 0.06
Nodes (10): GlbWriter, Count, Node, Primitive, Skin, PrefabExporter, Result, Part (+2 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (15): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+7 more)

### Community 12 - "Vegetation"
Cohesion: 0.12
Nodes (7): Class, Crunched, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.06
Nodes (18): MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel(), onPointerDown() (+10 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.05
Nodes (6): BufferAttribute, copyAttributeData(), DataUtils, denormalize(), Float16BufferAttribute, InterleavedBufferAttribute

### Community 16 - ".parseObject"
Cohesion: 0.05
Nodes (26): AnimationLoader, AudioLoader, handleError(), BufferGeometryLoader, getArrayBuffer(), getInterleavedBuffer(), CompressedTextureLoader, loadTexture() (+18 more)

### Community 17 - "BatchedMesh"
Cohesion: 0.07
Nodes (8): ascIdSort(), BatchedMesh, convertBufferAttribute(), CameraHelper, copyArrayContents(), EdgesGeometry, setPoint(), sortedArray()

### Community 18 - "Markers"
Cohesion: 0.06
Nodes (13): BaseOverride, BedSpot, Findable, Markers, Json, Rev, PartTimer, Portal (+5 more)

### Community 19 - "markers.js"
Cohesion: 0.07
Nodes (25): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), byName(), collator (+17 more)

### Community 20 - "Dictionary"
Cohesion: 0.08
Nodes (14): Info, ModelStore, Exported, MeshesPresent, MeshesWanted, PrefabsJson, QueueLength, Readable (+6 more)

### Community 21 - ".start"
Cohesion: 0.09
Nodes (9): App, BiomeHover, fromLatLng(), toLatLng(), esc(), ForgeCard, T(), weatherWord() (+1 more)

### Community 22 - "unityengine"
Cohesion: 0.16
Nodes (3): WebMap.Util, WebMap.MuninModels, WebMap.Tiles

### Community 23 - "Stats"
Cohesion: 0.08
Nodes (10): What a regression would do on the live server, worst first, DeathWatch, Boss, D, Kit, Spot, Standing, Stats (+2 more)

### Community 24 - "update"
Cohesion: 0.06
Nodes (48): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+40 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.08
Nodes (16): MapFog, Revision, ParticleSystem, ThreeDTests, Cat, Bush, Other, Piece (+8 more)

### Community 27 - "get"
Cohesion: 0.10
Nodes (62): WebGLCapabilities(), getMaxAnisotropy(), textureFormatReadable(), textureTypeReadable(), WebGLCubeMaps(), get(), mapTextureMapping(), onTextureDispose() (+54 more)

### Community 29 - "measure.js"
Cohesion: 0.06
Nodes (16): rgb(), WorldEdgeGL, BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool (+8 more)

### Community 31 - "Features"
Cohesion: 0.09
Nodes (6): Chart, Feature, Features, Grids, Named, Fnv

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

### Community 37 - ".applyMatrix4"
Cohesion: 0.05
Nodes (7): Camera, checkIntersection(), Frustum, SkinnedMesh, Sphere, testPoint(), transformVertex()

### Community 38 - ".constructor"
Cohesion: 0.16
Nodes (23): cloneUniforms(), getUnlitUniformColorSpace(), mergeUniforms(), WebGLBackground(), addToRenderList(), getBackground(), render(), setClear() (+15 more)

### Community 39 - "Vector2"
Cohesion: 0.04
Nodes (3): getBevelVec(), Vector2, ShadowUniformsCache()

### Community 40 - "playercard.js"
Cohesion: 0.08
Nodes (34): PlayerCard, getJSON(), activityHtml(), ARMOR_SLOTS, at(), BIOME_COL, clock(), connHtml() (+26 more)

### Community 41 - "Kitchen"
Cohesion: 0.06
Nodes (24): Deeds, DeedsGonePatch, DeedsRoutePatch, Kind, Kill, Rock, Tree, Last (+16 more)

### Community 42 - "JsonWriter"
Cohesion: 0.10
Nodes (10): 2.12.0, Entry, ItemIcons, Dir, Entry, MapIcons, Dir, Chunk (+2 more)

### Community 43 - "List"
Cohesion: 0.07
Nodes (14): Peak, Peaks, All, Kind, Runestones, Stone, Entry, Traders (+6 more)

### Community 44 - "leaflet.js"
Cohesion: 0.06
Nodes (33): Ae(), at(), be(), Ci(), d(), De(), e(), ei() (+25 more)

### Community 45 - "WebXRManager"
Cohesion: 0.07
Nodes (9): PlaneGeometry, WebGLAnimation(), onAnimationFrame(), onAnimationFrame(), WebXRDepthSensing, WebXRManager, setProjectionFromUnion(), updateCamera() (+1 more)

### Community 46 - "WebXRController"
Cohesion: 0.12
Nodes (3): Group, UniformsGroup, WebXRController

### Community 47 - ".Sweep"
Cohesion: 0.04
Nodes (22): Entry, Graves, Demisters, Dungeons, Signature, Inside, Visited, Kind (+14 more)

### Community 48 - "AuthTests"
Cohesion: 0.12
Nodes (3): Auth, Session, AuthTests

### Community 49 - "Mesh"
Cohesion: 0.06
Nodes (11): ArrowHelper, BoxGeometry, DirectionalLightHelper, HemisphereLightHelper, Line, Mesh, MeshBasicMaterial, PlaneHelper (+3 more)

### Community 50 - ".equals"
Cohesion: 0.08
Nodes (33): compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles(), filterPoints() (+25 more)

### Community 51 - "WebXRManager"
Cohesion: 0.07
Nodes (13): renderTarget(), WebGLCubeRenderTarget, WebGLRenderTarget, _createRenderTarget(), WebGLRenderer, renderTransmissionPass(), VSMPass(), drawBuffers() (+5 more)

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "RuinsLayer"
Cohesion: 0.12
Nodes (5): ChunkStore, parseVeg(), RegionLoader, RuinsLayer, RuinStore

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "Func"
Cohesion: 0.13
Nodes (6): Entry, Given, Settings, Live, Stats, WorldEvents

### Community 57 - "Light"
Cohesion: 0.07
Nodes (8): AmbientLight, DirectionalLight, HemisphereLight, Light, LightProbe, PointLight, RectAreaLight, SpotLight

### Community 58 - "Color"
Cohesion: 0.08
Nodes (4): Color, createColorManagement(), hue2rgb(), LinearToSRGB()

### Community 61 - "GateTests"
Cohesion: 0.08
Nodes (5): WebMapConfig, HeightMaxZoom, GateTests, LightModeTests, WithDir

### Community 62 - "TileStore"
Cohesion: 0.10
Nodes (7): TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered, RenderMsTotal

### Community 63 - "markercanvas.js"
Cohesion: 0.11
Nodes (12): asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache, labelImage() (+4 more)

### Community 64 - "Euler"
Cohesion: 0.09
Nodes (6): Euler, MeshLambertMaterial, MeshPhongMaterial, onQuaternionChange(), onRotationChange(), Scene

### Community 65 - "push"
Cohesion: 0.06
Nodes (32): ExternalTexture, getMaxPrecision(), WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights(), setup(), setupView() (+24 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.11
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Func"
Cohesion: 0.06
Nodes (15): Body, ChatRelay, Discord, Token, DiscordMessage, DiscordRef, Result, Migration (+7 more)

### Community 70 - "TileJob"
Cohesion: 0.13
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 72 - "PMREMGenerator"
Cohesion: 0.14
Nodes (11): ShaderMaterial, _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial(), PMREMGenerator, _setViewport(), WebGLCubeUVMaps() (+3 more)

### Community 73 - "Box2"
Cohesion: 0.11
Nodes (3): ascSort(), Box2, Raycaster

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

### Community 80 - "MapDataServer"
Cohesion: 0.08
Nodes (4): MapDataServer, PlayersWs, MapMessage, WebSocketHandler

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "TextureExtractor"
Cohesion: 0.15
Nodes (6): At, Source, TextureExtractor, LastFound, LastReport, Running

### Community 83 - "LoadingManager"
Cohesion: 0.07
Nodes (8): EventDispatcher, handleVisibilityChange(), ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), LoadingManager, Timer

### Community 86 - "BundleFile"
Cohesion: 0.15
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 87 - "TreesGL"
Cohesion: 0.20
Nodes (3): drawPicture(), ShapeCache, TreesGL

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
Cohesion: 0.14
Nodes (4): FeaturesTests, Grid, Cell, J

### Community 93 - "BuildingsGL"
Cohesion: 0.09
Nodes (7): BuildingsGL, hexRgb(), materialRgb(), PackedRegions, packRects(), RECT_LAYOUT(), RuinsGL

### Community 94 - "RaidLayer"
Cohesion: 0.20
Nodes (4): MapCore, ago(), areaImage(), RaidLayer

### Community 95 - "Activity"
Cohesion: 0.09
Nodes (8): Activity, Snap, Trail, Line, ServerLog, ActivityTests, Trails, ZNetPatchShutdown

### Community 96 - "web/js/view3d.js"
Cohesion: 0.13
Nodes (13): Street, _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), fallbackColor() (+5 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.15
Nodes (23): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+15 more)

### Community 99 - "BundleFile"
Cohesion: 0.17
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "AudioListener"
Cohesion: 0.09
Nodes (8): 2.9.1, AudioContext, AudioListener, Clock, ImageUtils, intersect(), serializeImage(), SRGBToLinear()

### Community 103 - "BiomeMap"
Cohesion: 0.13
Nodes (4): BiomeMap, Label, Now, Weather

### Community 104 - "Heights"
Cohesion: 0.19
Nodes (5): Heights, KeepSamples, Job, Served, Job

### Community 105 - "Using the map"
Cohesion: 0.10
Nodes (20): Chat commands, Checking the viewer against a live server, Coming from WebMap, Configuration, Discord, Features, Full-quality textures (optional), Install (+12 more)

### Community 106 - "Pieces"
Cohesion: 0.11
Nodes (7): HdMaps, Entry, Kind, Pieces, HdMapsTests, Sink, PiecesTests

### Community 108 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 110 - "Dictionary"
Cohesion: 0.17
Nodes (5): Decoded, MeshDecoder, Decoded, MeshDecoder, P

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.22
Nodes (3): GroundGL, perSide(), span()

### Community 113 - "Texture"
Cohesion: 0.05
Nodes (12): CanvasTexture, CubeTexture, Data3DTexture, DataArrayTexture, DepthTexture, FramebufferTexture, RenderTarget, RenderTarget3D (+4 more)

### Community 114 - "Changelog"
Cohesion: 0.10
Nodes (18): 2.11.0, 2.14.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog (+10 more)

### Community 115 - "Feed"
Cohesion: 0.20
Nodes (6): Ev, Feed, Keep, RecentJson, FeedTests, SkipToMorningPatch

### Community 116 - "TerrainPatches"
Cohesion: 0.22
Nodes (3): Patch, TerrainPatches, Count

### Community 117 - "Structures"
Cohesion: 0.05
Nodes (19): ChunkCache, Line, Regions, Chunk, Ruins, IndexJson, LastChanged, Total (+11 more)

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

### Community 124 - "Interpolant"
Cohesion: 0.18
Nodes (3): CubicInterpolant, DiscreteInterpolant, Interpolant

### Community 127 - "ContourGL"
Cohesion: 0.18
Nodes (3): ContourGL, labelImage(), span()

### Community 128 - ".load"
Cohesion: 0.14
Nodes (5): getImageURIMimeType(), GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension, LoaderUtils

### Community 129 - "AnimationClip"
Cohesion: 0.13
Nodes (5): AnimationClip, AnimationUtils, getTrackTypeForValueTypeName(), NumberKeyframeTrack, parseKeyframeTrack()

### Community 132 - "Fact"
Cohesion: 0.09
Nodes (7): PinsTests, File_, SettingsTests, StaticFilesTests, StatsTests, TilesTests, VersionTests

### Community 134 - ".constructor"
Cohesion: 0.08
Nodes (36): createCanvasElement(), createElementNS(), dispose(), WebGLMorphtargets(), update(), disposeTexture(), dispose(), getUniforms() (+28 more)

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - ".clone"
Cohesion: 0.05
Nodes (7): DirectionalLightShadow, LightShadow, OrthographicCamera, PerspectiveCamera, PointLightShadow, SpotLightShadow, StereoCamera

### Community 139 - "Png"
Cohesion: 0.19
Nodes (6): Format, Gray16, Gray8, RGB, RGBA, Png

### Community 140 - "Français"
Cohesion: 0.12
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 141 - "i18n.js"
Cohesion: 0.17
Nodes (7): Gear, fill(), has(), num(), t(), tn(), translateTree()

### Community 142 - "BuildHistory"
Cohesion: 0.29
Nodes (3): HotspotsTests, BuildHistory, Snap

### Community 143 - "Portals"
Cohesion: 0.17
Nodes (5): Testing, Entry, Last, Portals, PortalsTests

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 145 - "InterleavedBuffer"
Cohesion: 0.14
Nodes (3): generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer

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

### Community 159 - "SmoothZoom"
Cohesion: 0.36
Nodes (3): SmoothZoom, SmoothZoomControl, update()

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 167 - "WebP"
Cohesion: 0.20
Nodes (3): WorldPicture, WebP, Enabled

### Community 168 - "WebGLState"
Cohesion: 0.21
Nodes (18): WebGLState(), activeTexture(), ColorBuffer(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), reset() (+10 more)

### Community 169 - "oi"
Cohesion: 0.67
Nodes (4): Je(), ni(), oi(), si()

### Community 171 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 175 - "WebMap"
Cohesion: 0.04
Nodes (17): Announce, Token, Pending, DiscordWebHook, Ping, StaticCoroutine, StaticCoroutineRunner, WebMap (+9 more)

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
Cohesion: 0.17
Nodes (16): F(), G(), h(), i(), j(), k(), ke(), me() (+8 more)

### Community 203 - "bi"
Cohesion: 0.33
Nodes (6): ForgeMap 1.2.0, bi(), Pi(), q(), Ti(), u()

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 207 - "vegpack.js"
Cohesion: 0.10
Nodes (12): ObjectStore, VegStore, packTrees(), radiusOf(), RGB, seedOf(), SMALL_R, TREE_STRIDE (+4 more)

### Community 215 - "SerializedFile"
Cohesion: 0.19
Nodes (6): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeNode

### Community 216 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

## Knowledge Gaps
- **220 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+215 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1923 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **67 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `Func`, `Fact`, `HashSet`, `Kitchen`, `Pieces`, `Portals`, `AuthTests`, `MapDataServer`, `Changelog`, `LoadingManager`, `TerrainPatches`, `WebMap`, `WorldObjects`, `View3D`, `Activity`, `Features`?**
  _High betweenness centrality (0.362) - this node is a cross-community bridge._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _220 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007186411149825784 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `LoadingManager` to `three.core.js`, `three.module.js`, `Stats`?**
  _High betweenness centrality (0.310) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007857672349888807 - nodes in this community are weakly interconnected._
- **Why does `renderTarget()` connect `WebXRManager` to `get`, `app.js`, `TreesGL`?**
  _High betweenness centrality (0.071) - this node is a cross-community bridge._
- **Should `.push` be split into smaller, more focused modules?**
  _Cohesion score 0.031451266638042076 - nodes in this community are weakly interconnected._