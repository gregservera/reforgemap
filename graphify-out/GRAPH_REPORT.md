# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 221 files · ~719,897 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6795 nodes · 16492 edges · 234 communities (157 shown, 77 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 845 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `573bed90`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- three.core.js
- three.module.js
- .push
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
- renderTransmissionPass
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
- Vehicles
- WebXRController
- Vector3
- AuthTests
- Mesh
- .equals
- WebXRManager
- Vector4
- Veg
- net.js
- PropertyBinding
- WebMapConfig
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
- JsonParser
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
- addToRenderList
- AnimationMixer
- BundleFile
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
- TileMath
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
- Dictionary
- Hand
- GroundGL
- RenderTarget
- Changelog
- WorldEvents
- TerrainPatches
- Structures
- arraysEqual
- .LookJson
- map-core.test.mjs
- Locations
- CurvePath
- Deeds
- Interpolant
- KitchenTests
- ContourGL
- .load
- AnimationClip
- CubicBezierCurve
- .SetName
- Fact
- Timer
- .constructor
- TextureDecoder
- BufferGeometryUtils.js
- .clone
- QuadraticBezierCurve
- Png
- Français
- i18n.js
- BuildHistory
- .Sweep
- PolyhedronGeometry
- InterleavedBuffer
- d
- AudioListener
- WebMap.cs
- AltBiomeGL
- CompressedTexture
- check.mjs
- ShaderMaterial
- parseUniform
- bench.mjs
- TextureDecoder
- .canopyMaterial
- MistGL
- FallbackTileLayer
- SmoothZoom
- WebGLPrograms
- .parse
- addShape
- ZNetPeer
- LineCurve
- VideoTexture
- .Read
- WebP
- WebGLState
- BiomeGL
- Preview
- fetchTerrarium
- Made
- .KindOf
- ZNetPeer
- m
- EllipseCurve
- Material
- Spherical
- WebMap.Tests.csproj
- WebMap.csproj
- CubicPoly
- Type
- render
- Kind
- getKeyframeOrder
- GLTFMaterialsDispersionExtension
- Cylindrical
- GLBufferAttribute
- Object3D
- FogExp2
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- k
- ArrayCamera
- .NewWorld
- MeshPhysicalMaterial
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- PositionalAudio
- .Of
- .Start
- bi
- Third-party notices
- system
- .load
- vegpack.js
- TextureUtils
- .lerp
- testserver.sh
- MultiDrawRenderList
- Uniform
- layers.js
- SerializedFile
- GuideGL
- probeAsync
- worldkeys.js
- Clock
- AudioAnalyser
- StaticFilesTests
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

## Communities (234 total, 77 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (219): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+211 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (42): _cache, DefaultLoadingManager, Int16BufferAttribute, InterpolationSamplingMode, InterpolationSamplingType, MOUSE, UniformsUtils, arrayCacheF32 (+34 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (41): AxesHelper, Box3Helper, buildPlane(), BoxHelper, BufferGeometry, CameraHelper, addLine(), addPoint() (+33 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (71): chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM, TILE (+63 more)

### Community 4 - ".copy"
Cohesion: 0.04
Nodes (14): a(), c(), x(), handleTriangle(), handleVertex(), checkGeometryIntersection(), checkIntersection$1(), Line3 (+6 more)

### Community 5 - "Matrix4"
Cohesion: 0.03
Nodes (8): Camera, checkIntersection(), CubeCamera, FrustumArray, InstancedMesh, Matrix4, OrthographicCamera, SkinnedMesh

### Community 6 - "Vector3"
Cohesion: 0.04
Nodes (13): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+5 more)

### Community 7 - "BatchedMesh"
Cohesion: 0.05
Nodes (8): ascIdSort(), BatchedMesh, Bone, CatmullRomCurve3, flattenJSON(), InstancedBufferAttribute, Matrix2, Skeleton

### Community 8 - "ForestMap"
Cohesion: 0.14
Nodes (8): Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump, Tree

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (56): byName(), statsHtml(), BIOME_SVG, breakable(), BUILD_SVG, BUSH_SVG, busyChart(), CONTOUR_SVG (+48 more)

### Community 10 - ".Export"
Cohesion: 0.07
Nodes (10): GlbWriter, Count, Node, Primitive, Skin, PrefabExporter, Result, Part (+2 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (15): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+7 more)

### Community 12 - "Vegetation"
Cohesion: 0.15
Nodes (7): Class, Crunched, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.06
Nodes (18): MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel(), onPointerDown() (+10 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.05
Nodes (9): BufferAttribute, copyAttributeData(), createColorManagement(), DataUtils, denormalize(), Float16BufferAttribute, InterleavedBufferAttribute, isUniqueEdge() (+1 more)

### Community 16 - ".parseObject"
Cohesion: 0.06
Nodes (16): 2.9.1, getArrayBuffer(), getInterleavedBuffer(), CubeTexture, DataTexture, Fog, getTypedArray(), ImageLoader (+8 more)

### Community 17 - "renderTransmissionPass"
Cohesion: 0.15
Nodes (11): WebGLRenderTarget, getMaxPrecision(), getChannel(), getParameters(), renderObject(), renderObjects(), renderTransmissionPass(), WebGLShadowMap() (+3 more)

### Community 18 - "Markers"
Cohesion: 0.06
Nodes (13): BaseOverride, BedSpot, Findable, Markers, Json, Rev, PartTimer, Portal (+5 more)

### Community 19 - "markers.js"
Cohesion: 0.05
Nodes (40): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), ALIAS, colors (+32 more)

### Community 20 - "Dictionary"
Cohesion: 0.08
Nodes (15): Data, MeshCache, Info, ModelStore, Exported, MeshesPresent, MeshesWanted, PrefabsJson (+7 more)

### Community 21 - ".start"
Cohesion: 0.08
Nodes (8): App, BiomeHover, fromLatLng(), esc(), ForgeCard, T(), weatherWord(), windWord()

### Community 22 - "unityengine"
Cohesion: 0.16
Nodes (3): WebMap.Util, WebMap.MuninModels, WebMap.Tiles

### Community 23 - "Stats"
Cohesion: 0.11
Nodes (7): What a regression would do on the live server, worst first, Boss, D, Kit, Spot, Standing, Stats

### Community 24 - "update"
Cohesion: 0.07
Nodes (43): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+35 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.09
Nodes (16): MapFog, Revision, ParticleSystem, ThreeDTests, Cat, Bush, Other, Piece (+8 more)

### Community 27 - "get"
Cohesion: 0.08
Nodes (66): createElementNS(), WebGLCapabilities(), getMaxAnisotropy(), textureFormatReadable(), textureTypeReadable(), WebGLProperties(), get(), has() (+58 more)

### Community 29 - "measure.js"
Cohesion: 0.06
Nodes (17): FogGL, rgb(), WorldEdgeGL, BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime() (+9 more)

### Community 31 - "Features"
Cohesion: 0.18
Nodes (3): Feature, Features, Grids

### Community 32 - "ForgeCanvas"
Cohesion: 0.07
Nodes (11): Tour, DeathsLayer, fogUsers, ForgeCanvas, loadFog(), MC, walkedFn(), PathsLayer (+3 more)

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
Cohesion: 0.05
Nodes (5): ascSort(), Box2, Frustum, Raycaster, Sphere

### Community 38 - ".constructor"
Cohesion: 0.33
Nodes (14): WebGLMaterials(), refreshMaterialUniforms(), refreshTransformUniform(), refreshUniformsCommon(), refreshUniformsDash(), refreshUniformsDistance(), refreshUniformsLine(), refreshUniformsMatcap() (+6 more)

### Community 40 - "playercard.js"
Cohesion: 0.06
Nodes (50): PlayerCard, BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light() (+42 more)

### Community 42 - "JsonWriter"
Cohesion: 0.09
Nodes (9): 2.12.0, Entry, ItemIcons, Dir, Entry, MapIcons, Dir, JsonWriter (+1 more)

### Community 43 - "List"
Cohesion: 0.14
Nodes (6): Peak, Peaks, All, Kind, Runestones, Stone

### Community 44 - "leaflet.js"
Cohesion: 0.07
Nodes (20): Ae(), Ci(), ei(), Ie(), ii(), Je(), Jt(), l() (+12 more)

### Community 45 - "Vehicles"
Cohesion: 0.16
Nodes (6): Entry, Kind, Boat, Cart, None, Vehicles

### Community 46 - "WebXRController"
Cohesion: 0.10
Nodes (3): Group, UniformsGroup, WebXRController

### Community 47 - "Vector3"
Cohesion: 0.08
Nodes (15): Dungeons, Signature, Inside, Visited, Kind, Chest, Gate, Generator (+7 more)

### Community 48 - "AuthTests"
Cohesion: 0.10
Nodes (3): Auth, Session, AuthTests

### Community 49 - "Mesh"
Cohesion: 0.05
Nodes (15): ArrowHelper, BoxGeometry, convertBufferAttribute(), ConeGeometry, Controls, copyArrayContents(), DirectionalLightHelper, HemisphereLightHelper (+7 more)

### Community 50 - ".equals"
Cohesion: 0.07
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebXRManager"
Cohesion: 0.06
Nodes (11): renderTarget(), WebGLRenderer, viewport(), WebXRManager, onAnimationFrame(), onInputSourcesChange(), onSessionEnd(), onSessionEvent() (+3 more)

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "net.js"
Cohesion: 0.05
Nodes (22): ChunkStore, ObjectStore, parseVeg(), RegionLoader, VegStore, CanvasOverlay, FogLayer, RuinsLayer (+14 more)

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 57 - "Light"
Cohesion: 0.11
Nodes (5): AmbientLight, HemisphereLight, Light, LightProbe, RectAreaLight

### Community 58 - "Color"
Cohesion: 0.09
Nodes (3): Color, hue2rgb(), LinearToSRGB()

### Community 61 - "GateTests"
Cohesion: 0.10
Nodes (3): GateTests, LightModeTests, WithDir

### Community 62 - "TileStore"
Cohesion: 0.10
Nodes (7): TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered, RenderMsTotal

### Community 63 - "markercanvas.js"
Cohesion: 0.13
Nodes (6): asDot(), countBadge(), labelImage(), labelWidth(), MarkerCanvas, MarkerGL

### Community 64 - "Euler"
Cohesion: 0.09
Nodes (6): Euler, MeshLambertMaterial, MeshPhongMaterial, onQuaternionChange(), onRotationChange(), Scene

### Community 65 - "push"
Cohesion: 0.08
Nodes (25): ExternalTexture, ShadowUniformsCache(), UniformsCache(), WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights(), setup() (+17 more)

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
Cohesion: 0.13
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 71 - "Curve"
Cohesion: 0.13
Nodes (3): CatmullRom(), Curve, SplineCurve

### Community 72 - "PMREMGenerator"
Cohesion: 0.11
Nodes (14): WebGLCubeRenderTarget, _createRenderTarget(), PMREMGenerator, _setViewport(), WebGLCubeMaps(), get(), mapTextureMapping(), onTextureDispose() (+6 more)

### Community 74 - "Matrix3"
Cohesion: 0.05
Nodes (6): CanvasTexture, DepthTexture, FramebufferTexture, Matrix3, Source, Texture

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
Cohesion: 0.10
Nodes (9): Coming from WebMap, Install, BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, QuaternionKeyframeTrack, StringKeyframeTrack, subclip() (+1 more)

### Community 79 - "Items"
Cohesion: 0.15
Nodes (3): Items, Ready, ItemsTests

### Community 80 - "MapDataServer"
Cohesion: 0.06
Nodes (5): MapDataServer, PlayersWs, MapMessage, WebSocketHandler, Trails

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "TextureExtractor"
Cohesion: 0.16
Nodes (6): At, Source, TextureExtractor, LastFound, LastReport, Running

### Community 83 - "LoadingManager"
Cohesion: 0.11
Nodes (6): EventDispatcher, ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), LoadingManager

### Community 84 - "addToRenderList"
Cohesion: 0.36
Nodes (9): cloneUniforms(), getUnlitUniformColorSpace(), mergeUniforms(), WebGLBackground(), addToRenderList(), dispose(), getBackground(), render() (+1 more)

### Community 86 - "BundleFile"
Cohesion: 0.15
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 87 - "WebGLProgram"
Cohesion: 0.08
Nodes (25): fetchAttributeLocations(), filterEmptyLine(), generateCubeUVSize(), generateDefines(), generateEnvMapBlendingDefine(), generateEnvMapModeDefine(), generateEnvMapTypeDefine(), generatePrecision() (+17 more)

### Community 88 - "HashSet"
Cohesion: 0.10
Nodes (11): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running (+3 more)

### Community 89 - "SerializedFile"
Cohesion: 0.16
Nodes (8): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode, TypeInfo

### Community 90 - "GLTFParser"
Cohesion: 0.20
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.10
Nodes (7): Testing, FeaturesTests, PiecesTests, PortalsTests, Grid, Cell, J

### Community 92 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 93 - "ChunkShapes"
Cohesion: 0.04
Nodes (14): BuildingsGL, ChunkShapes, compile(), drawPicture(), hexRgb(), materialRgb(), PackedRegions, packRects() (+6 more)

### Community 94 - "RaidLayer"
Cohesion: 0.18
Nodes (5): MapCore, ago(), areaCache, areaImage(), RaidLayer

### Community 95 - "Activity"
Cohesion: 0.13
Nodes (7): Activity, Snap, Trail, Line, ServerLog, ActivityTests, ZNetPatchShutdown

### Community 96 - "web/js/view3d.js"
Cohesion: 0.13
Nodes (13): Street, _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), fallbackColor() (+5 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.13
Nodes (22): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+14 more)

### Community 99 - "BundleFile"
Cohesion: 0.17
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "Clock"
Cohesion: 0.25
Nodes (4): AudioContext, ImageUtils, serializeImage(), SRGBToLinear()

### Community 102 - "Path"
Cohesion: 0.10
Nodes (4): Path, Shape, ShapePath, toShapesNoHoles()

### Community 104 - "Heights"
Cohesion: 0.19
Nodes (5): Heights, KeepSamples, Job, Served, Job

### Community 105 - "Using the map"
Cohesion: 0.11
Nodes (18): Chat commands, Checking the viewer against a live server, Configuration, Discord, Features, Full-quality textures (optional), Licence and credit, Local test server (+10 more)

### Community 106 - "Pieces"
Cohesion: 0.12
Nodes (6): HdMaps, Entry, Kind, Pieces, HdMapsTests, Sink

### Community 108 - "Loader"
Cohesion: 0.09
Nodes (13): AnimationLoader, AudioLoader, handleError(), BufferGeometryLoader, CompressedTextureLoader, loadTexture(), CubeTextureLoader, loadTexture() (+5 more)

### Community 110 - "Dictionary"
Cohesion: 0.16
Nodes (5): Decoded, MeshDecoder, Decoded, MeshDecoder, P

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.22
Nodes (3): GroundGL, perSide(), span()

### Community 113 - "RenderTarget"
Cohesion: 0.13
Nodes (6): Data3DTexture, DataArrayTexture, RenderTarget, RenderTarget3D, WebGL3DRenderTarget, WebGLArrayRenderTarget

### Community 114 - "Changelog"
Cohesion: 0.10
Nodes (18): 2.11.0, 2.14.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog (+10 more)

### Community 115 - "WorldEvents"
Cohesion: 0.11
Nodes (9): Ev, Feed, Keep, RecentJson, FeedTests, SkipToMorningPatch, WorldEvents, InvasionsPath (+1 more)

### Community 116 - "TerrainPatches"
Cohesion: 0.11
Nodes (7): Patch, TerrainPatches, Count, LocationTerrain, Count, Mod, Patch

### Community 117 - "Structures"
Cohesion: 0.05
Nodes (22): ChunkCache, Line, Regions, Chunk, Ruins, IndexJson, LastChanged, Total (+14 more)

### Community 118 - "arraysEqual"
Cohesion: 0.15
Nodes (24): allocTexUnits(), arraysEqual(), copyArray(), setValueM2(), setValueM3(), setValueM4(), setValueT1(), setValueT1Array() (+16 more)

### Community 119 - ".LookJson"
Cohesion: 0.20
Nodes (5): Item, Joints, Look, Rig, RigTests

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 123 - "Deeds"
Cohesion: 0.25
Nodes (4): Deeds, DeedsRoutePatch, Last, DeedsTests

### Community 124 - "Interpolant"
Cohesion: 0.17
Nodes (4): CubicInterpolant, DiscreteInterpolant, Interpolant, LinearInterpolant

### Community 127 - "ContourGL"
Cohesion: 0.18
Nodes (3): ContourGL, labelImage(), span()

### Community 128 - ".load"
Cohesion: 0.14
Nodes (5): getImageURIMimeType(), GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension, LoaderUtils

### Community 129 - "AnimationClip"
Cohesion: 0.11
Nodes (5): AnimationClip, AnimationUtils, getTrackTypeForValueTypeName(), NumberKeyframeTrack, parseKeyframeTrack()

### Community 130 - "CubicBezierCurve"
Cohesion: 0.12
Nodes (7): CubicBezier(), CubicBezierCurve, CubicBezierCurve3, CubicBezierP0(), CubicBezierP1(), CubicBezierP2(), CubicBezierP3()

### Community 132 - "Fact"
Cohesion: 0.09
Nodes (6): PinsTests, File_, SettingsTests, StatsTests, TilesTests, VersionTests

### Community 134 - ".constructor"
Cohesion: 0.09
Nodes (36): createCanvasElement(), WebGLAnimation(), onAnimationFrame(), refreshFogUniforms(), WebGLMorphtargets(), update(), disposeTexture(), WebGLPrograms() (+28 more)

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - ".clone"
Cohesion: 0.04
Nodes (10): DirectionalLight, DirectionalLightShadow, Layers, LightShadow, PerspectiveCamera, PointLight, PointLightShadow, SpotLight (+2 more)

### Community 138 - "QuadraticBezierCurve"
Cohesion: 0.12
Nodes (6): QuadraticBezier(), QuadraticBezierCurve, QuadraticBezierCurve3, QuadraticBezierP0(), QuadraticBezierP1(), QuadraticBezierP2()

### Community 139 - "Png"
Cohesion: 0.19
Nodes (6): Format, Gray16, Gray8, RGB, RGBA, Png

### Community 140 - "Français"
Cohesion: 0.13
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 141 - "i18n.js"
Cohesion: 0.17
Nodes (7): Gear, fill(), has(), num(), t(), tn(), translateTree()

### Community 142 - "BuildHistory"
Cohesion: 0.39
Nodes (3): HotspotsTests, BuildHistory, Snap

### Community 143 - ".Sweep"
Cohesion: 0.05
Nodes (10): Entry, Graves, Entry, Last, Portals, Demisters, Hotspots, Json (+2 more)

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 145 - "InterleavedBuffer"
Cohesion: 0.12
Nodes (3): generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer

### Community 146 - "d"
Cohesion: 0.25
Nodes (9): at(), d(), ht(), i(), Li(), Mi(), v(), W() (+1 more)

### Community 148 - "WebMap.cs"
Cohesion: 0.15
Nodes (6): Announce, Token, Pending, DeathWatch, ZRoutedRpcPatch, ZRoutedRpcRoutePatch

### Community 150 - "CompressedTexture"
Cohesion: 0.25
Nodes (3): CompressedArrayTexture, CompressedCubeTexture, CompressedTexture

### Community 151 - "check.mjs"
Cohesion: 0.32
Nodes (11): [BASE, PORT, OUT], check(), map(), open(), plan(), players(), portals(), sleep() (+3 more)

### Community 152 - "ShaderMaterial"
Cohesion: 0.28
Nodes (7): cloneUniformsGroups(), RawShaderMaterial, ShaderMaterial, _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial()

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

### Community 162 - "addShape"
Cohesion: 0.27
Nodes (11): addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3(), f4(), getBevelVec() (+3 more)

### Community 163 - "ZNetPeer"
Cohesion: 0.15
Nodes (6): Ping, Window, PingTests, ZNetPatchDisconnect, ZNetPatchStart, ZRoutedRpcAddPeerPatch

### Community 168 - "WebGLState"
Cohesion: 0.19
Nodes (19): WebGLState(), ColorBuffer(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), reset(), scissor() (+11 more)

### Community 169 - "BiomeGL"
Cohesion: 0.22
Nodes (3): 2.13.0, bigText(), BiomeGL

### Community 171 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 173 - "Made"
Cohesion: 0.33
Nodes (6): Made, Brewed, Burnt, Cooked, Honey, Smelted

### Community 175 - "ZNetPeer"
Cohesion: 0.10
Nodes (4): DiscordWebHook, WebMap, ZNetPatchSetServer, ZoneSystemLoadPatch

### Community 176 - "m"
Cohesion: 0.31
Nodes (9): be(), De(), m(), p(), pe(), ve(), xe(), ye() (+1 more)

### Community 178 - "Material"
Cohesion: 0.12
Nodes (16): Material, Ashwood, BlackMarble, Cloth, CoreWood, Crystal, DarkWood, Fire (+8 more)

### Community 180 - "WebMap.Tests.csproj"
Cohesion: 0.29
Nodes (5): net10.0, Microsoft.NET.Test.Sdk (17.14.1), xunit (2.9.3), xunit.runner.visualstudio (3.1.4), Microsoft.NET.Sdk

### Community 181 - "WebMap.csproj"
Cohesion: 0.29
Nodes (6): net48, ILRepack.Lib.MSBuild.Task (2.0.44.2), Krafs.Publicizer (2.2.1), Microsoft.NETFramework.ReferenceAssemblies (1.0.3), SixLabors.ImageSharp (2.1.13), Microsoft.NET.Sdk

### Community 183 - "Type"
Cohesion: 0.40
Nodes (5): Type, Brew, Cook, Hive, Smelt

### Community 184 - "render"
Cohesion: 0.43
Nodes (4): load(), message(), render(), Spot

### Community 185 - "Kind"
Cohesion: 0.50
Nodes (4): Kind, Kill, Rock, Tree

### Community 190 - "Object3D"
Cohesion: 0.05
Nodes (4): LOD, Object3D, _points, Sprite

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 194 - "k"
Cohesion: 0.27
Nodes (11): F(), G(), h(), j(), k(), ke(), ne(), e() (+3 more)

### Community 202 - ".Start"
Cohesion: 0.18
Nodes (3): StaticCoroutine, StaticCoroutineRunner, ZoneSystemPatch

### Community 203 - "bi"
Cohesion: 0.22
Nodes (9): ForgeMap 1.2.0, bi(), e(), hi(), Pi(), q(), Qe(), Ti() (+1 more)

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 205 - "system"
Cohesion: 0.11
Nodes (3): WebMap.Models.Unity, WebMap.MuninModels.Unity, WebMap.Models

### Community 207 - "vegpack.js"
Cohesion: 0.23
Nodes (10): packTrees(), radiusOf(), RGB, seedOf(), SMALL_R, TREE_STRIDE, unpackRegion(), VEG (+2 more)

### Community 215 - "SerializedFile"
Cohesion: 0.19
Nodes (6): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeNode

### Community 216 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

## Knowledge Gaps
- **220 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+215 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1923 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **77 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `Fact`, `Timer`, `ForestMap`, `.Sweep`, `WebMap.cs`, `WorldObjects`, `View3D`, `Features`, `.KindOf`, `ZNetPeer`, `AuthTests`, `Func`, `.Of`, `MapDataServer`, `HashSet`, `Fact`, `Pieces`, `Changelog`, `TerrainPatches`, `Deeds`?**
  _High betweenness centrality (0.336) - this node is a cross-community bridge._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _220 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.00803187250996016 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `Timer` to `three.core.js`, `three.module.js`, `LoadingManager`, `Stats`?**
  _High betweenness centrality (0.285) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.008093355919442876 - nodes in this community are weakly interconnected._
- **Why does `initGLContext()` connect `.constructor` to `push`, `WebGLBindingStates`, `.constructor`, `playercard.js`, `PMREMGenerator`, `WebGLState`, `renderTransmissionPass`, `addToRenderList`, `update`, `get`?**
  _High betweenness centrality (0.072) - this node is a cross-community bridge._
- **Should `.push` be split into smaller, more focused modules?**
  _Cohesion score 0.02916783151616811 - nodes in this community are weakly interconnected._