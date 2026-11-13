# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 207 files · ~702,850 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6602 nodes · 15867 edges · 237 communities (160 shown, 77 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 746 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `6cb8472e`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- three.core.js
- three.module.js
- BufferGeometry
- app.js
- .copy
- Object3D
- Vector3
- BatchedMesh
- .Sweep
- ui.js
- .Export
- View3D
- Ruins
- OrbitControls
- BufferAttribute
- List
- Chart
- WebGLRenderer
- Markers
- markers.js
- Dictionary
- .start
- WebGLState
- Stats
- update
- textures-hd.py
- WorldObjects
- get
- View3D
- measure.js
- system
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
- ZDOID
- JsonWriter
- xunit
- leaflet.js
- Matrix4
- WebXRController
- Vector3
- AuthTests
- .constructor
- .equals
- WebXRManager
- Vector4
- Veg
- FogLayer
- PropertyBinding
- GateTests
- .parseObject
- Color
- Quaternion
- Box3
- .constructor
- TileStore
- markercanvas.js
- Euler
- push
- GLTFLoader.js
- InlineData
- Discord
- AnimationAction
- TileJob
- Curve
- PMREMGenerator
- Feed
- Texture
- web/js/sky.js
- RigBuilder
- .constructor
- KeyframeTrack
- Items
- MapDataServer
- .assignTexture
- Func
- LoadingManager
- JsonElement
- AnimationMixer
- .applyMatrix4
- WebGLProgram
- HashSet
- SerializedFile
- GLTFParser
- Fact
- MigrationTests
- ChunkShapes
- RaidLayer
- WebMap
- web/js/view3d.js
- Matrix3
- WebGLBindingStates
- BundleFile
- package.json
- Clock
- Path
- BiomeMap
- Heights
- Using the map
- .fromBufferAttribute
- PropertyMixer
- Loader
- toLatLng
- MeshDecoder
- Hand
- GroundGL
- system_io
- Changelog
- WorldEvents
- TerrainPatches
- Structures
- arraysEqual
- .LookJson
- map-core.test.mjs
- Locations
- TileMath
- Deeds
- .distanceTo
- particles.js
- WithDir
- ContourGL
- .load
- AnimationClip
- CubicBezierCurve
- Mesh
- Fact
- Material
- initGLContext
- addToRenderList
- BufferGeometryUtils.js
- .multiplyMatrices
- QuadraticBezierCurve
- Png
- Français
- i18n.js
- PerspectiveCamera
- Interpolant
- PolyhedronGeometry
- InterleavedBuffer
- Feed
- Part
- WebMap.cs
- .Analyse
- GlbWriter
- check.mjs
- ChatRelay
- parseUniform
- bench.mjs
- TextureDecoder
- .canopyMaterial
- .for
- FallbackTileLayer
- SmoothZoom
- vegpack.js
- .parse
- .push
- Timer
- k
- VideoTexture
- WebGLShaderCache
- WebP
- Regex
- BiomeGL
- Preview
- .constructor
- ServerLog
- .RefreshPlayerSnapshot
- PositionalAudio
- ZNetPeer
- m
- EllipseCurve
- CompressedTexture
- Spherical
- WebMap.Tests.csproj
- WebMap.csproj
- Using the map
- Window
- render
- fetchTerrarium
- .Of
- WebGLCubeRenderTarget
- Cylindrical
- GLBufferAttribute
- flatten
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- WorldEvents
- .NewWorld
- MeshPhysicalMaterial
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- Controls
- SplineCurve
- .Start
- bi
- Third-party notices
- .load
- .load
- .setIndex
- TextureUtils
- createColorManagement
- testserver.sh
- allocateTextureUnit
- MultiDrawRenderList
- Uniform
- layers.js
- Cat
- CubicPoly
- getKeyframeOrder
- WebSocketHandler
- BoxHelper
- probeAsync
- .constructor
- oi
- Setup
- StaticFilesTests
- worldkeys.js
- .lerp
- ArrayCamera
- WebGLShaderStage

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
10. `View3D` - 61 edges

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

## Communities (237 total, 77 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (219): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+211 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (33): ColorManagement, DefaultLoadingManager, InterpolationSamplingMode, MOUSE, TOUCH, arrayCacheF32, arrayCacheI32, _axisDirections (+25 more)

### Community 2 - "BufferGeometry"
Cohesion: 0.06
Nodes (19): AxesHelper, Box3Helper, BufferGeometry, CameraHelper, addLine(), addPoint(), EdgesGeometry, Float32BufferAttribute (+11 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (77): chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM, TILE (+69 more)

### Community 4 - ".copy"
Cohesion: 0.05
Nodes (13): a(), c(), x(), handleTriangle(), handleVertex(), checkGeometryIntersection(), checkIntersection$1(), isUniqueEdge() (+5 more)

### Community 5 - "Object3D"
Cohesion: 0.07
Nodes (3): DirectionalLightHelper, Object3D, _points

### Community 6 - "Vector3"
Cohesion: 0.04
Nodes (3): setPoint(), Vector3, UniformsCache()

### Community 7 - "BatchedMesh"
Cohesion: 0.05
Nodes (8): ascIdSort(), BatchedMesh, CatmullRomCurve3, DataTexture, flattenJSON(), InstancedBufferAttribute, InstancedMesh, Matrix2

### Community 8 - ".Sweep"
Cohesion: 0.04
Nodes (24): Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump, Tree (+16 more)

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (59): OBJECT_CATS, iconSvg(), escape(), makeIcon(), statsHtml(), BIOME_SVG, breakable(), BUILD_SVG (+51 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (15): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+7 more)

### Community 12 - "Ruins"
Cohesion: 0.05
Nodes (18): ChunkCache, Line, Regions, Chunk, Ruins, IndexJson, LastChanged, Total (+10 more)

### Community 13 - "OrbitControls"
Cohesion: 0.06
Nodes (18): MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel(), onPointerDown() (+10 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.04
Nodes (13): BufferAttribute, CapsuleGeometry, DataUtils, denormalize(), Float16BufferAttribute, Int16BufferAttribute, Int32BufferAttribute, Int8BufferAttribute (+5 more)

### Community 15 - "List"
Cohesion: 0.15
Nodes (6): Peak, Peaks, All, Kind, Runestones, Stone

### Community 17 - "WebGLRenderer"
Cohesion: 0.07
Nodes (16): WebGLRenderTarget, _createRenderTarget(), getMaxPrecision(), getChannel(), getParameters(), WebGLRenderer, renderTransmissionPass(), VSMPass() (+8 more)

### Community 18 - "Markers"
Cohesion: 0.06
Nodes (12): BaseOverride, BedSpot, Findable, Markers, Json, Rev, Portal, SignSpot (+4 more)

### Community 19 - "markers.js"
Cohesion: 0.06
Nodes (31): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), badgeCache, gamePinImage() (+23 more)

### Community 20 - "Dictionary"
Cohesion: 0.09
Nodes (15): Data, MeshCache, Info, ModelStore, Exported, MeshesPresent, MeshesWanted, PrefabsJson (+7 more)

### Community 21 - ".start"
Cohesion: 0.09
Nodes (7): App, BiomeHover, fromLatLng(), toLatLng(), esc(), ForgeCard, T()

### Community 22 - "WebGLState"
Cohesion: 0.30
Nodes (15): WebGLState(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), setBlending(), setCullFace(), setFlipSided() (+7 more)

### Community 23 - "Stats"
Cohesion: 0.09
Nodes (8): What a regression would do on the live server, worst first, Boss, D, Kit, Spot, Standing, Stats, StatsTests

### Community 24 - "update"
Cohesion: 0.07
Nodes (45): arrayNeedsUint32(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer(), WebGLBufferRenderer() (+37 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.12
Nodes (9): MapFog, Revision, ParticleSystem, ThreeDTests, Chunk, Obj, Rock, WorldObjects (+1 more)

### Community 27 - "get"
Cohesion: 0.11
Nodes (55): createElementNS(), getMaxAnisotropy(), has(), getContext(), get(), activeTexture(), bindFramebuffer(), bindTexture() (+47 more)

### Community 29 - "measure.js"
Cohesion: 0.09
Nodes (14): BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool, MINUTES, reachBands() (+6 more)

### Community 30 - "system"
Cohesion: 0.10
Nodes (3): WebMap.Models.Unity, WebMap, WebMap.Models

### Community 32 - "ForgeCanvas"
Cohesion: 0.06
Nodes (14): Tour, DeathsLayer, fogUsers, ForgeCanvas, loadFog(), MC, walkedFn(), PathsLayer (+6 more)

### Community 34 - "Material"
Cohesion: 0.06
Nodes (10): LineDashedMaterial, Material, MeshDepthMaterial, MeshDistanceMaterial, MeshMatcapMaterial, MeshNormalMaterial, MeshToonMaterial, PointsMaterial (+2 more)

### Community 35 - "Gear"
Cohesion: 0.07
Nodes (20): Armor, Heavy, Light, Mage, Medium, None, Diet, Balanced (+12 more)

### Community 36 - "activity.js"
Cohesion: 0.08
Nodes (17): ActivityLayers, colorRgb(), fmtAgo(), fmtClock(), fmtSpan(), gridOverlay(), HEAT, hslRgb() (+9 more)

### Community 37 - "Sphere"
Cohesion: 0.06
Nodes (4): ascSort(), Box2, Raycaster, Sphere

### Community 38 - ".constructor"
Cohesion: 0.14
Nodes (24): WebGLMaterials(), refreshFogUniforms(), refreshMaterialUniforms(), refreshTransformUniform(), refreshUniformsCommon(), refreshUniformsDash(), refreshUniformsDistance(), refreshUniformsLine() (+16 more)

### Community 40 - "playercard.js"
Cohesion: 0.05
Nodes (39): PlayerCard, ChunkStore, parseVeg(), RegionLoader, RuinsLayer, RuinStore, getJSON(), activityHtml() (+31 more)

### Community 41 - "ZDOID"
Cohesion: 0.09
Nodes (15): Kind, Kitchen, Made, Brewed, Burnt, Cooked, Honey, Smelted (+7 more)

### Community 42 - "JsonWriter"
Cohesion: 0.14
Nodes (3): PartTimer, JsonWriter, Length

### Community 44 - "leaflet.js"
Cohesion: 0.07
Nodes (23): Ae(), at(), Ci(), d(), ei(), ht(), i(), Ie() (+15 more)

### Community 45 - "Matrix4"
Cohesion: 0.05
Nodes (4): AudioListener, Bone, Matrix4, Skeleton

### Community 46 - "WebXRController"
Cohesion: 0.10
Nodes (3): Group, UniformsGroup, WebXRController

### Community 47 - "Vector3"
Cohesion: 0.09
Nodes (14): Demisters, Dungeons, Signature, Inside, Visited, Kind, Chest, Gate (+6 more)

### Community 48 - "AuthTests"
Cohesion: 0.15
Nodes (3): Auth, Session, AuthTests

### Community 49 - ".constructor"
Cohesion: 0.06
Nodes (9): ArrowHelper, BoxGeometry, ConeGeometry, copyArrayContents(), CylinderGeometry, HemisphereLightHelper, MeshBasicMaterial, PointLightHelper (+1 more)

### Community 50 - ".equals"
Cohesion: 0.08
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebXRManager"
Cohesion: 0.07
Nodes (8): WebGLAnimation(), onAnimationFrame(), onAnimationFrame(), WebXRDepthSensing, WebXRManager, setProjectionFromUnion(), updateCamera(), updateUserCamera()

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "FogLayer"
Cohesion: 0.08
Nodes (13): ObjectStore, VegStore, FogLayer, connect(), emit(), evKey(), fetchEarly(), frame() (+5 more)

### Community 55 - "PropertyBinding"
Cohesion: 0.07
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 57 - ".parseObject"
Cohesion: 0.04
Nodes (15): AmbientLight, DirectionalLight, Fog, FogExp2, HemisphereLight, Light, LightProbe, LineLoop (+7 more)

### Community 61 - ".constructor"
Cohesion: 0.16
Nodes (19): createCanvasElement(), releaseShaderCache(), deallocateMaterial(), getProgram(), materialNeedsLights(), onContextCreationError(), onContextLost(), onContextRestore() (+11 more)

### Community 62 - "TileStore"
Cohesion: 0.11
Nodes (7): TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered, RenderMsTotal

### Community 63 - "markercanvas.js"
Cohesion: 0.13
Nodes (6): asDot(), countBadge(), labelImage(), labelWidth(), MarkerCanvas, MarkerGL

### Community 64 - "Euler"
Cohesion: 0.09
Nodes (6): Euler, MeshLambertMaterial, MeshPhongMaterial, onQuaternionChange(), onRotationChange(), Scene

### Community 65 - "push"
Cohesion: 0.09
Nodes (29): WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights(), setup(), setupView(), WebGLPrograms(), acquireProgram() (+21 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.10
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Discord"
Cohesion: 0.11
Nodes (6): Body, Discord, Token, DiscordRef, Result, DiscordTests

### Community 70 - "TileJob"
Cohesion: 0.13
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 71 - "Curve"
Cohesion: 0.09
Nodes (3): Curve, LineCurve, LineCurve3

### Community 72 - "PMREMGenerator"
Cohesion: 0.13
Nodes (12): RawShaderMaterial, ShaderMaterial, _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial(), PMREMGenerator, _setViewport() (+4 more)

### Community 74 - "Texture"
Cohesion: 0.05
Nodes (12): CanvasTexture, CubeTexture, Data3DTexture, DataArrayTexture, DepthTexture, FramebufferTexture, RenderTarget, RenderTarget3D (+4 more)

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
Cohesion: 0.09
Nodes (7): BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, LinearInterpolant, QuaternionKeyframeTrack, StringKeyframeTrack, VectorKeyframeTrack

### Community 79 - "Items"
Cohesion: 0.13
Nodes (3): Items, Ready, ItemsTests

### Community 81 - ".assignTexture"
Cohesion: 0.06
Nodes (8): GLTFMaterialsAnisotropyExtension, GLTFMaterialsBumpExtension, GLTFMaterialsIridescenceExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "Func"
Cohesion: 0.19
Nodes (3): Entry, Given, Settings

### Community 83 - "LoadingManager"
Cohesion: 0.11
Nodes (6): EventDispatcher, ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), LoadingManager

### Community 84 - "JsonElement"
Cohesion: 0.23
Nodes (4): Entry, Last, Portals, PortalsTests

### Community 86 - ".applyMatrix4"
Cohesion: 0.10
Nodes (4): Camera, checkIntersection(), SkinnedMesh, testPoint()

### Community 87 - "WebGLProgram"
Cohesion: 0.08
Nodes (25): fetchAttributeLocations(), filterEmptyLine(), generateCubeUVSize(), generateDefines(), generateEnvMapBlendingDefine(), generateEnvMapModeDefine(), generateEnvMapTypeDefine(), generatePrecision() (+17 more)

### Community 88 - "HashSet"
Cohesion: 0.14
Nodes (8): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running

### Community 89 - "SerializedFile"
Cohesion: 0.20
Nodes (7): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode

### Community 90 - "GLTFParser"
Cohesion: 0.19
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.16
Nodes (4): FeaturesTests, Grid, Cell, J

### Community 92 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 93 - "ChunkShapes"
Cohesion: 0.04
Nodes (14): BuildingsGL, ChunkShapes, compile(), drawPicture(), hexRgb(), materialRgb(), PackedRegions, packRects() (+6 more)

### Community 94 - "RaidLayer"
Cohesion: 0.18
Nodes (5): MapCore, ago(), areaCache, areaImage(), RaidLayer

### Community 95 - "WebMap"
Cohesion: 0.10
Nodes (4): DiscordWebHook, WebMap, ZNetPatchSetServer, ZoneSystemLoadPatch

### Community 96 - "web/js/view3d.js"
Cohesion: 0.13
Nodes (13): Street, _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), fallbackColor() (+5 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.13
Nodes (22): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+14 more)

### Community 99 - "BundleFile"
Cohesion: 0.12
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "Clock"
Cohesion: 0.14
Nodes (6): 2.9.1, AudioContext, Clock, ImageUtils, intersect(), serializeImage()

### Community 104 - "Heights"
Cohesion: 0.17
Nodes (5): Heights, KeepSamples, Job, Served, Job

### Community 105 - "Using the map"
Cohesion: 0.12
Nodes (12): Checking the viewer against a live server, Coming from WebMap, Configuration, Features, Install, Licence and credit, Local test server, Notes for developers (+4 more)

### Community 106 - ".fromBufferAttribute"
Cohesion: 0.08
Nodes (3): copyAttributeData(), InterleavedBufferAttribute, WireframeGeometry

### Community 108 - "Loader"
Cohesion: 0.06
Nodes (22): AnimationLoader, AudioLoader, handleError(), BufferGeometryLoader, getArrayBuffer(), getInterleavedBuffer(), CompressedTextureLoader, loadTexture() (+14 more)

### Community 110 - "MeshDecoder"
Cohesion: 0.21
Nodes (3): Decoded, MeshDecoder, P

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.21
Nodes (4): GroundGL, perSide(), span(), screenArea()

### Community 114 - "Changelog"
Cohesion: 0.13
Nodes (14): 2.10.0, 2.11.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog (+6 more)

### Community 115 - "WorldEvents"
Cohesion: 0.22
Nodes (3): WorldEvents, InvasionsPath, StatePath

### Community 116 - "TerrainPatches"
Cohesion: 0.12
Nodes (7): Patch, TerrainPatches, Count, LocationTerrain, Count, Mod, Patch

### Community 117 - "Structures"
Cohesion: 0.10
Nodes (11): Base, Chunk, Piece, Shape, Structures, Builders, IndexJson, LastChanged (+3 more)

### Community 118 - "arraysEqual"
Cohesion: 0.21
Nodes (19): allocTexUnits(), arraysEqual(), copyArray(), setValueM2(), setValueM3(), setValueM4(), setValueT1Array(), setValueT2DArrayArray() (+11 more)

### Community 119 - ".LookJson"
Cohesion: 0.13
Nodes (7): Item, Joints, Look, Rig, Player, RigExporter, RigTests

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 123 - "Deeds"
Cohesion: 0.14
Nodes (9): Deeds, DeedsGonePatch, DeedsRoutePatch, Kind, Kill, Rock, Tree, Last (+1 more)

### Community 125 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 126 - "WithDir"
Cohesion: 0.15
Nodes (4): PiecesTests, PinsTests, File_, WithDir

### Community 127 - "ContourGL"
Cohesion: 0.18
Nodes (3): ContourGL, labelImage(), span()

### Community 128 - ".load"
Cohesion: 0.20
Nodes (3): GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension

### Community 129 - "AnimationClip"
Cohesion: 0.14
Nodes (4): AnimationClip, AnimationUtils, NumberKeyframeTrack, subclip()

### Community 130 - "CubicBezierCurve"
Cohesion: 0.12
Nodes (7): CubicBezier(), CubicBezierCurve, CubicBezierCurve3, CubicBezierP0(), CubicBezierP1(), CubicBezierP2(), CubicBezierP3()

### Community 132 - "Fact"
Cohesion: 0.12
Nodes (5): GearTests, PreviewTests, SettingsTests, TilesTests, VersionTests

### Community 133 - "Material"
Cohesion: 0.12
Nodes (16): Material, Ashwood, BlackMarble, Cloth, CoreWood, Crystal, DarkWood, Fire (+8 more)

### Community 134 - "initGLContext"
Cohesion: 0.13
Nodes (13): renderTarget(), ExternalTexture, warnOnce(), WebGLCapabilities(), textureFormatReadable(), textureTypeReadable(), WebGLExtensions(), getExtension() (+5 more)

### Community 135 - "addToRenderList"
Cohesion: 0.27
Nodes (10): cloneUniforms(), cloneUniformsGroups(), getUnlitUniformColorSpace(), mergeUniforms(), WebGLBackground(), addToRenderList(), dispose(), getBackground() (+2 more)

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - ".multiplyMatrices"
Cohesion: 0.06
Nodes (7): CubeCamera, DirectionalLightShadow, FrustumArray, LightShadow, OrthographicCamera, PointLightShadow, SpotLightShadow

### Community 138 - "QuadraticBezierCurve"
Cohesion: 0.12
Nodes (6): QuadraticBezier(), QuadraticBezierCurve, QuadraticBezierCurve3, QuadraticBezierP0(), QuadraticBezierP1(), QuadraticBezierP2()

### Community 139 - "Png"
Cohesion: 0.19
Nodes (6): Format, Gray16, Gray8, RGB, RGBA, Png

### Community 140 - "Français"
Cohesion: 0.15
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 141 - "i18n.js"
Cohesion: 0.17
Nodes (7): Gear, fill(), has(), num(), t(), tn(), translateTree()

### Community 142 - "PerspectiveCamera"
Cohesion: 0.10
Nodes (3): Layers, PerspectiveCamera, StereoCamera

### Community 143 - "Interpolant"
Cohesion: 0.18
Nodes (3): CubicInterpolant, DiscreteInterpolant, Interpolant

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 145 - "InterleavedBuffer"
Cohesion: 0.08
Nodes (5): convertBufferAttribute(), generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer, sortedArray()

### Community 146 - "Feed"
Cohesion: 0.20
Nodes (6): Ev, Feed, Keep, RecentJson, FeedTests, SkipToMorningPatch

### Community 148 - "WebMap.cs"
Cohesion: 0.20
Nodes (3): DeathWatch, ZRoutedRpcPatch, ZRoutedRpcRoutePatch

### Community 150 - "GlbWriter"
Cohesion: 0.20
Nodes (5): GlbWriter, Count, Primitive, Skin, Result

### Community 151 - "check.mjs"
Cohesion: 0.32
Nodes (11): [BASE, PORT, OUT], check(), map(), open(), plan(), players(), portals(), sleep() (+3 more)

### Community 152 - "ChatRelay"
Cohesion: 0.26
Nodes (3): ChatRelay, DiscordMessage, ChatRelayTests

### Community 153 - "parseUniform"
Cohesion: 0.17
Nodes (7): addUniform(), getPureArraySetter(), getSingularSetter(), parseUniform(), PureArrayUniform, SingleUniform, StructuredUniform

### Community 154 - "bench.mjs"
Cohesion: 0.22
Nodes (10): 2.12.0, [BASE, PORT], errors, ev(), ms(), pending, send(), tab (+2 more)

### Community 157 - ".for"
Cohesion: 0.05
Nodes (8): AltBiomeGL, FogGL, glyphAtlas(), GuideGL, MistGL, rgb(), textImage(), WorldEdgeGL

### Community 159 - "SmoothZoom"
Cohesion: 0.36
Nodes (3): SmoothZoom, SmoothZoomControl, update()

### Community 160 - "vegpack.js"
Cohesion: 0.25
Nodes (9): packTrees(), radiusOf(), RGB, seedOf(), SMALL_R, TREE_STRIDE, unpackRegion(), VEG (+1 more)

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 162 - ".push"
Cohesion: 0.05
Nodes (26): CurvePath, ExtrudeGeometry, addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3() (+18 more)

### Community 164 - "k"
Cohesion: 0.22
Nodes (13): F(), G(), h(), j(), k(), ke(), me(), ne() (+5 more)

### Community 168 - "Regex"
Cohesion: 0.20
Nodes (3): HdMaps, HdMapsTests, Sink

### Community 169 - "BiomeGL"
Cohesion: 0.13
Nodes (8): 2.13.0, 2.14.0, HTTP endpoints, look(), time(), bigText(), BiomeGL, ct()

### Community 171 - ".constructor"
Cohesion: 0.30
Nodes (11): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+3 more)

### Community 172 - "ServerLog"
Cohesion: 0.27
Nodes (3): Line, ServerLog, ZNetPatchShutdown

### Community 175 - "ZNetPeer"
Cohesion: 0.09
Nodes (8): Announce, Token, Pending, MapMessage, Ping, ZNetPatchDisconnect, ZNetPatchStart, ZRoutedRpcAddPeerPatch

### Community 176 - "m"
Cohesion: 0.23
Nodes (12): be(), De(), e(), hi(), m(), p(), pe(), Qe() (+4 more)

### Community 178 - "CompressedTexture"
Cohesion: 0.25
Nodes (3): CompressedArrayTexture, CompressedCubeTexture, CompressedTexture

### Community 180 - "WebMap.Tests.csproj"
Cohesion: 0.29
Nodes (5): net10.0, Microsoft.NET.Test.Sdk (17.14.1), xunit (2.9.3), xunit.runner.visualstudio (3.1.4), Microsoft.NET.Sdk

### Community 181 - "WebMap.csproj"
Cohesion: 0.29
Nodes (6): net48, ILRepack.Lib.MSBuild.Task (2.0.44.2), Krafs.Publicizer (2.2.1), Microsoft.NETFramework.ReferenceAssemblies (1.0.3), SixLabors.ImageSharp (2.1.13), Microsoft.NET.Sdk

### Community 182 - "Using the map"
Cohesion: 0.20
Nodes (9): Chat commands, Discord, Full-quality textures (optional), Server announcements, Signing in with Discord, The 3D view, The cinematic, The model library (+1 more)

### Community 184 - "render"
Cohesion: 0.43
Nodes (4): load(), message(), render(), Spot

### Community 185 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 187 - "WebGLCubeRenderTarget"
Cohesion: 0.28
Nodes (7): WebGLCubeRenderTarget, WebGLCubeMaps(), get(), mapTextureMapping(), onTextureDispose(), onTextureDispose(), onTextureDispose()

### Community 191 - "flatten"
Cohesion: 0.29
Nodes (7): flatten(), setValueM2Array(), setValueM3Array(), setValueM4Array(), setValueV2fArray(), setValueV3fArray(), setValueV4fArray()

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 195 - "WorldEvents"
Cohesion: 0.33
Nodes (3): Live, Stats, WorldEvents

### Community 196 - ".NewWorld"
Cohesion: 0.19
Nodes (3): WebMapConfig, HeightMaxZoom, ImageConv

### Community 202 - ".Start"
Cohesion: 0.20
Nodes (3): StaticCoroutine, StaticCoroutineRunner, ZoneSystemPatch

### Community 203 - "bi"
Cohesion: 0.33
Nodes (6): ForgeMap 1.2.0, bi(), Pi(), q(), Ti(), u()

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 207 - ".setIndex"
Cohesion: 0.09
Nodes (8): buildPlane(), CircleGeometry, generateCap(), generateTorso(), InstancedBufferGeometry, RingGeometry, addShape(), TorusGeometry

### Community 209 - "createColorManagement"
Cohesion: 0.29
Nodes (3): createColorManagement(), LinearToSRGB(), SRGBToLinear()

### Community 211 - "allocateTextureUnit"
Cohesion: 0.40
Nodes (5): setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), allocateTextureUnit()

### Community 215 - "Cat"
Cohesion: 0.29
Nodes (7): Cat, Bush, Other, Piece, Rock, Skip, Tree

### Community 223 - "oi"
Cohesion: 0.67
Nodes (4): Je(), ni(), oi(), si()

## Knowledge Gaps
- **214 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+209 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1906 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **77 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `Timer`, `Discord`, `.Sweep`, `Using the map`, `.RefreshPlayerSnapshot`, `AuthTests`, `Chart`, `MapDataServer`, `Changelog`, `WebMap.cs`, `JsonElement`, `TerrainPatches`, `ChatRelay`, `WorldObjects`, `Deeds`, `View3D`, `WebMap`, `Features`?**
  _High betweenness centrality (0.337) - this node is a cross-community bridge._
- **Are the 7 inferred relationships involving `get()` (e.g. with `WebGLAttributes()` and `WebGLCubeMaps()`) actually correct?**
  _`get()` has 7 INFERRED edges - model-reasoned connections that need verification._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _214 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.00803187250996016 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `Timer` to `three.core.js`, `three.module.js`, `LoadingManager`, `Stats`?**
  _High betweenness centrality (0.280) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.00823045267489712 - nodes in this community are weakly interconnected._
- **Why does `initGLContext()` connect `initGLContext` to `push`, `WebGLBindingStates`, `.constructor`, `addToRenderList`, `playercard.js`, `PMREMGenerator`, `get`, `WebGLState`, `update`, `WebGLCubeRenderTarget`, `.constructor`?**
  _High betweenness centrality (0.076) - this node is a cross-community bridge._