# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 222 files · ~720,401 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6805 nodes · 16523 edges · 221 communities (157 shown, 64 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 847 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `411a587d`
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
- Matrix4
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
- Sphere
- .constructor
- Vector2
- playercard.js
- Kitchen
- JsonWriter
- List
- leaflet.js
- WebXRManager
- .fromBufferAttribute
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
- .build
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
- .getContext
- Path
- BiomeMap
- Heights
- particles.js
- Regex
- PropertyMixer
- .copy
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
- .clone
- system_io
- Interpolant
- .need
- Deeds
- ContourGL
- .load
- AnimationClip
- EventDispatcher
- WebGLProgram
- Fact
- MigrationTests
- .constructor
- TextureDecoder
- BufferGeometryUtils.js
- .clone
- .multiplyMatrices
- Png
- JsonParser
- i18n.js
- BuildHistory
- Portals
- PolyhedronGeometry
- InterleavedBuffer
- Layers
- LineSegments
- WebMap
- .for
- CompressedTexture
- check.mjs
- parseUniform
- bench.mjs
- TextureDecoder
- .canopyMaterial
- MistGL
- FallbackTileLayer
- SmoothZoom
- .copy
- .parse
- PositionalAudio
- Window
- addToRenderList
- VideoTexture
- addShape
- WebP
- WebGLState
- oi
- Preview
- fetchTerrarium
- Setup
- ServerLog
- m
- IEnumerator
- AudioListener
- EllipseCurve
- Material
- WebGLShaderCache
- WebMap.Tests.csproj
- WebMap.csproj
- Trails
- Clock
- render
- WebMapConfig
- AudioAnalyser
- GLTFMaterialsDispersionExtension
- Cylindrical
- GLBufferAttribute
- StaticFilesTests
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- k
- Matrix2
- Texture2D
- MeshPhysicalMaterial
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- ArrayCamera
- probeAsync
- WebGLShaderStage
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

## Communities (221 total, 64 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (226): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+218 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (38): ColorManagement, InterpolationSamplingMode, InterpolationSamplingType, MOUSE, arrayCacheF32, arrayCacheI32, _axisDirections, _clearColor (+30 more)

### Community 2 - ".push"
Cohesion: 0.04
Nodes (32): buildPlane(), BufferGeometry, addLine(), addPoint(), CapsuleGeometry, CircleGeometry, generateCap(), generateTorso() (+24 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (74): BiomeHover, chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM (+66 more)

### Community 4 - ".copy"
Cohesion: 0.05
Nodes (7): a(), c(), checkGeometryIntersection(), Plane, Ray, satForAxes(), Triangle

### Community 5 - "Object3D"
Cohesion: 0.05
Nodes (5): Group, Object3D, Sprite, UniformsGroup, WebXRController

### Community 6 - "Vector3"
Cohesion: 0.03
Nodes (12): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+4 more)

### Community 7 - "Matrix4"
Cohesion: 0.05
Nodes (5): Bone, Camera, Matrix4, OrthographicCamera, Skeleton

### Community 8 - "HashSet"
Cohesion: 0.06
Nodes (17): Chart, Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump (+9 more)

### Community 9 - "ui.js"
Cohesion: 0.04
Nodes (63): OBJECT_CATS, escape(), BIOME_SVG, breakable(), BUILD_SVG, BUSH_SVG, busyChart(), CONTOUR_SVG (+55 more)

### Community 10 - ".Export"
Cohesion: 0.06
Nodes (10): GlbWriter, Count, Node, Primitive, Skin, PrefabExporter, Result, Part (+2 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (15): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+7 more)

### Community 12 - "Vegetation"
Cohesion: 0.11
Nodes (7): Class, Crunched, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 13 - "OrbitControls"
Cohesion: 0.05
Nodes (19): PlayerCard, MapControls, _changeEvent, _endEvent, onKeyDown(), onMouseDown(), onMouseMove(), onMouseWheel() (+11 more)

### Community 14 - "BufferAttribute"
Cohesion: 0.05
Nodes (11): BufferAttribute, DataUtils, denormalize(), Float16BufferAttribute, Int16BufferAttribute, Int32BufferAttribute, Int8BufferAttribute, Uint16BufferAttribute (+3 more)

### Community 16 - ".parseObject"
Cohesion: 0.05
Nodes (18): 2.9.1, getArrayBuffer(), getInterleavedBuffer(), DataTexture, Fog, FogExp2, getTrackTypeForValueTypeName(), getTypedArray() (+10 more)

### Community 17 - "BatchedMesh"
Cohesion: 0.07
Nodes (6): ascIdSort(), BatchedMesh, CatmullRom(), copyArrayContents(), flattenJSON(), SplineCurve

### Community 18 - "Markers"
Cohesion: 0.06
Nodes (13): BaseOverride, BedSpot, Findable, Markers, Json, Rev, PartTimer, Portal (+5 more)

### Community 19 - "markers.js"
Cohesion: 0.06
Nodes (31): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), ALIAS, colors (+23 more)

### Community 20 - "Dictionary"
Cohesion: 0.09
Nodes (15): Data, MeshCache, Info, ModelStore, Exported, MeshesPresent, MeshesWanted, PrefabsJson (+7 more)

### Community 21 - ".start"
Cohesion: 0.09
Nodes (7): App, fromLatLng(), esc(), ForgeCard, T(), weatherWord(), windWord()

### Community 22 - "unityengine"
Cohesion: 0.15
Nodes (3): WebMap.Util, WebMap.MuninModels, WebMap.Tiles

### Community 23 - "Stats"
Cohesion: 0.08
Nodes (10): What a regression would do on the live server, worst first, DeathWatch, Boss, D, Kit, Spot, Standing, Stats (+2 more)

### Community 24 - "update"
Cohesion: 0.07
Nodes (39): warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer(), WebGLBufferRenderer() (+31 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.08
Nodes (16): MapFog, Revision, ParticleSystem, ThreeDTests, Cat, Bush, Other, Piece (+8 more)

### Community 27 - "get"
Cohesion: 0.09
Nodes (68): createElementNS(), getByteLength(), getTextureTypeByteLength(), setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), WebGLCapabilities() (+60 more)

### Community 29 - "measure.js"
Cohesion: 0.09
Nodes (14): BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool, MINUTES, reachBands() (+6 more)

### Community 31 - "Features"
Cohesion: 0.11
Nodes (4): Feature, Features, Grids, Named

### Community 32 - "ForgeCanvas"
Cohesion: 0.06
Nodes (14): Tour, DeathsLayer, fogUsers, ForgeCanvas, loadFog(), MC, walkedFn(), PathsLayer (+6 more)

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
Nodes (3): Box2, Frustum, Sphere

### Community 38 - ".constructor"
Cohesion: 0.16
Nodes (21): WebGLMaterials(), refreshFogUniforms(), refreshMaterialUniforms(), refreshTransformUniform(), refreshUniformsCommon(), refreshUniformsDash(), refreshUniformsDistance(), refreshUniformsLine() (+13 more)

### Community 40 - "playercard.js"
Cohesion: 0.09
Nodes (36): activityHtml(), ARMOR_SLOTS, at(), BIOME_COL, clock(), connHtml(), day(), dayLabel() (+28 more)

### Community 41 - "Kitchen"
Cohesion: 0.09
Nodes (15): Kind, Kitchen, Made, Brewed, Burnt, Cooked, Honey, Smelted (+7 more)

### Community 42 - "JsonWriter"
Cohesion: 0.08
Nodes (12): 2.12.0, Entry, ItemIcons, Dir, Entry, MapIcons, Dir, Chunk (+4 more)

### Community 43 - "List"
Cohesion: 0.07
Nodes (14): Peak, Peaks, All, Kind, Runestones, Stone, Entry, Traders (+6 more)

### Community 44 - "leaflet.js"
Cohesion: 0.07
Nodes (21): Ae(), at(), Ci(), d(), ei(), ht(), Ie(), ii() (+13 more)

### Community 45 - "WebXRManager"
Cohesion: 0.07
Nodes (11): WebGLAnimation(), onAnimationFrame(), onAnimationFrame(), WebXRDepthSensing, WebXRManager, onInputSourcesChange(), onSessionEnd(), onSessionEvent() (+3 more)

### Community 46 - ".fromBufferAttribute"
Cohesion: 0.06
Nodes (7): CameraHelper, copyAttributeData(), EdgesGeometry, HemisphereLightHelper, InterleavedBufferAttribute, setPoint(), SkeletonHelper

### Community 47 - ".Sweep"
Cohesion: 0.04
Nodes (22): Entry, Graves, Demisters, Dungeons, Signature, Inside, Visited, Kind (+14 more)

### Community 48 - "AuthTests"
Cohesion: 0.15
Nodes (3): Auth, Session, AuthTests

### Community 49 - "Mesh"
Cohesion: 0.06
Nodes (12): ArrowHelper, BoxGeometry, ConeGeometry, CylinderGeometry, DirectionalLightHelper, Line, Mesh, MeshBasicMaterial (+4 more)

### Community 50 - ".equals"
Cohesion: 0.09
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebXRManager"
Cohesion: 0.09
Nodes (7): WebGLRenderTarget, getMaxPrecision(), getChannel(), getParameters(), WebGLRenderer, renderTransmissionPass(), VSMPass()

### Community 52 - "Vector4"
Cohesion: 0.04
Nodes (3): Spherical, toHalfFloat(), Vector4

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "net.js"
Cohesion: 0.05
Nodes (19): ChunkStore, ObjectStore, parseVeg(), RegionLoader, VegStore, FogLayer, RuinsLayer, RuinStore (+11 more)

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "Func"
Cohesion: 0.13
Nodes (6): Entry, Given, Settings, Live, Stats, WorldEvents

### Community 57 - "Light"
Cohesion: 0.09
Nodes (6): AmbientLight, HemisphereLight, Light, PointLight, RectAreaLight, SpotLight

### Community 58 - "Color"
Cohesion: 0.06
Nodes (6): CatmullRomCurve3, Color, createColorManagement(), hue2rgb(), LinearToSRGB(), getTexture()

### Community 59 - "Quaternion"
Cohesion: 0.09
Nodes (3): 2.13.0, makeClipAdditive(), Quaternion

### Community 60 - "Box3"
Cohesion: 0.06
Nodes (4): Box3, InstancedBufferAttribute, InstancedMesh, SkinnedMesh

### Community 61 - "GateTests"
Cohesion: 0.10
Nodes (3): GateTests, LightModeTests, WithDir

### Community 62 - "TileStore"
Cohesion: 0.10
Nodes (7): TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered, RenderMsTotal

### Community 63 - "markercanvas.js"
Cohesion: 0.11
Nodes (12): asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache, labelImage() (+4 more)

### Community 64 - "Euler"
Cohesion: 0.13
Nodes (3): Euler, onQuaternionChange(), onRotationChange()

### Community 65 - "push"
Cohesion: 0.07
Nodes (33): ExternalTexture, shadowCastingAndTexturingLightsFirst(), ShadowUniformsCache(), UniformsCache(), WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights() (+25 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.10
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Func"
Cohesion: 0.08
Nodes (9): Body, ChatRelay, Discord, Token, DiscordMessage, DiscordRef, Result, ChatRelayTests (+1 more)

### Community 70 - "TileJob"
Cohesion: 0.13
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 71 - "Curve"
Cohesion: 0.05
Nodes (10): CubicBezierCurve3, Curve, LineCurve, LineCurve3, QuadraticBezier(), QuadraticBezierCurve, QuadraticBezierCurve3, QuadraticBezierP0() (+2 more)

### Community 72 - "PMREMGenerator"
Cohesion: 0.09
Nodes (20): RawShaderMaterial, ShaderMaterial, WebGLCubeRenderTarget, _createRenderTarget(), _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial() (+12 more)

### Community 73 - "Loader"
Cohesion: 0.10
Nodes (13): AnimationLoader, AudioLoader, handleError(), BufferGeometryLoader, CompressedTextureLoader, loadTexture(), CubeTextureLoader, loadTexture() (+5 more)

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
Cohesion: 0.08
Nodes (10): Coming from WebMap, Install, BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, LinearInterpolant, QuaternionKeyframeTrack, StringKeyframeTrack (+2 more)

### Community 80 - "MapDataServer"
Cohesion: 0.05
Nodes (9): MapDataServer, PlayersWs, MapMessage, WebSocketHandler, Ping, ZNetPatchDisconnect, ZNetPatchStart, ZoneSystemLoadPatch (+1 more)

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "TextureExtractor"
Cohesion: 0.16
Nodes (6): At, Source, TextureExtractor, LastFound, LastReport, Running

### Community 83 - "LoadingManager"
Cohesion: 0.15
Nodes (5): ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), LoadingManager

### Community 86 - "BundleFile"
Cohesion: 0.14
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 87 - ".build"
Cohesion: 0.21
Nodes (3): compile(), drawPicture(), ShapeCache

### Community 88 - "HashSet"
Cohesion: 0.12
Nodes (8): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running

### Community 89 - "SerializedFile"
Cohesion: 0.20
Nodes (7): LeReader, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode, TypeInfo

### Community 90 - "GLTFParser"
Cohesion: 0.20
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.14
Nodes (4): FeaturesTests, Grid, Cell, J

### Community 92 - "ShapesCanvas"
Cohesion: 0.17
Nodes (3): renderTarget(), screenArea(), ShapesCanvas

### Community 93 - "BuildingsGL"
Cohesion: 0.08
Nodes (7): BuildingsGL, hexRgb(), materialRgb(), PackedRegions, packRects(), RECT_LAYOUT(), RuinsGL

### Community 94 - "RaidLayer"
Cohesion: 0.18
Nodes (5): MapCore, ago(), areaCache, areaImage(), RaidLayer

### Community 95 - "Activity"
Cohesion: 0.24
Nodes (4): Activity, Snap, Trail, ActivityTests

### Community 96 - "web/js/view3d.js"
Cohesion: 0.13
Nodes (13): Street, _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), fallbackColor() (+5 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.17
Nodes (21): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+13 more)

### Community 99 - "BundleFile"
Cohesion: 0.17
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - ".getContext"
Cohesion: 0.29
Nodes (3): AudioContext, ImageUtils, SRGBToLinear()

### Community 102 - "Path"
Cohesion: 0.06
Nodes (6): CubicBezierCurve, CurvePath, Path, Shape, ShapePath, toShapesNoHoles()

### Community 104 - "Heights"
Cohesion: 0.20
Nodes (5): Heights, KeepSamples, Job, Served, Job

### Community 105 - "particles.js"
Cohesion: 0.05
Nodes (48): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+40 more)

### Community 106 - "Regex"
Cohesion: 0.18
Nodes (3): HdMaps, HdMapsTests, Sink

### Community 108 - ".copy"
Cohesion: 0.13
Nodes (5): handleTriangle(), handleVertex(), isUniqueEdge(), SphericalHarmonics3, transformVertex()

### Community 110 - "Dictionary"
Cohesion: 0.14
Nodes (6): Decoded, MeshDecoder, MeshData, Decoded, MeshDecoder, P

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.22
Nodes (3): GroundGL, perSide(), span()

### Community 113 - "Texture"
Cohesion: 0.05
Nodes (13): CanvasTexture, CubeTexture, Data3DTexture, DataArrayTexture, DepthTexture, FramebufferTexture, RenderTarget, RenderTarget3D (+5 more)

### Community 114 - "Changelog"
Cohesion: 0.10
Nodes (18): 2.11.0, 2.14.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog (+10 more)

### Community 115 - "Feed"
Cohesion: 0.20
Nodes (6): Ev, Feed, Keep, RecentJson, FeedTests, SkipToMorningPatch

### Community 116 - "TerrainPatches"
Cohesion: 0.17
Nodes (3): Patch, TerrainPatches, Count

### Community 117 - "Structures"
Cohesion: 0.05
Nodes (21): ChunkCache, Line, Regions, Chunk, Ruins, IndexJson, LastChanged, Total (+13 more)

### Community 118 - "arraysEqual"
Cohesion: 0.21
Nodes (19): allocTexUnits(), arraysEqual(), copyArray(), setValueM2(), setValueM3(), setValueM4(), setValueT1Array(), setValueT2DArrayArray() (+11 more)

### Community 119 - ".LookJson"
Cohesion: 0.19
Nodes (5): Item, Joints, Look, Rig, RigTests

### Community 120 - "map-core.test.mjs"
Cohesion: 0.13
Nodes (10): browser, MapCore, prefabs, src, stored, bare, browser, I18N (+2 more)

### Community 121 - "Locations"
Cohesion: 0.21
Nodes (5): Entry, Locations, RevealedCount, VegvisirAnswerPatch, LocationsTests

### Community 122 - ".clone"
Cohesion: 0.08
Nodes (7): checkIntersection(), checkIntersection$1(), scalePt2(), Line3, LOD, _points, testPoint()

### Community 124 - "Interpolant"
Cohesion: 0.18
Nodes (3): CubicInterpolant, DiscreteInterpolant, Interpolant

### Community 126 - "Deeds"
Cohesion: 0.14
Nodes (9): Deeds, DeedsGonePatch, DeedsRoutePatch, Kind, Kill, Rock, Tree, Last (+1 more)

### Community 127 - "ContourGL"
Cohesion: 0.18
Nodes (3): ContourGL, labelImage(), span()

### Community 128 - ".load"
Cohesion: 0.14
Nodes (5): getImageURIMimeType(), GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension, LoaderUtils

### Community 129 - "AnimationClip"
Cohesion: 0.15
Nodes (3): AnimationClip, AnimationUtils, NumberKeyframeTrack

### Community 130 - "EventDispatcher"
Cohesion: 0.08
Nodes (6): convertBufferAttribute(), Controls, EventDispatcher, handleVisibilityChange(), sortedArray(), Timer

### Community 131 - "WebGLProgram"
Cohesion: 0.08
Nodes (25): fetchAttributeLocations(), filterEmptyLine(), generateCubeUVSize(), generateDefines(), generateEnvMapBlendingDefine(), generateEnvMapModeDefine(), generateEnvMapTypeDefine(), generatePrecision() (+17 more)

### Community 132 - "Fact"
Cohesion: 0.08
Nodes (7): ItemsTests, PinsTests, File_, SettingsTests, StatsTests, TilesTests, VersionTests

### Community 133 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 134 - ".constructor"
Cohesion: 0.08
Nodes (36): arrayNeedsUint32(), createCanvasElement(), WebGLGeometries(), get(), getWireframeAttribute(), onGeometryDispose(), update(), updateWireframeAttribute() (+28 more)

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - ".clone"
Cohesion: 0.06
Nodes (6): DirectionalLight, DirectionalLightShadow, LightShadow, PerspectiveCamera, PointLightShadow, SpotLightShadow

### Community 139 - "Png"
Cohesion: 0.19
Nodes (6): Format, Gray16, Gray8, RGB, RGBA, Png

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
Cohesion: 0.12
Nodes (3): generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer

### Community 146 - "Layers"
Cohesion: 0.11
Nodes (4): ascSort(), Layers, Raycaster, StereoCamera

### Community 147 - "LineSegments"
Cohesion: 0.13
Nodes (6): AxesHelper, Box3Helper, BoxHelper, GridHelper, LineSegments, PolarGridHelper

### Community 148 - "WebMap"
Cohesion: 0.13
Nodes (3): DiscordWebHook, WebMap, ZNetPatchSetServer

### Community 149 - ".for"
Cohesion: 0.05
Nodes (9): AltBiomeGL, bigText(), BiomeGL, FogGL, glyphAtlas(), GuideGL, rgb(), textImage() (+1 more)

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

### Community 160 - ".copy"
Cohesion: 0.14
Nodes (3): MeshLambertMaterial, MeshPhongMaterial, Scene

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 164 - "addToRenderList"
Cohesion: 0.27
Nodes (10): cloneUniforms(), cloneUniformsGroups(), getUnlitUniformColorSpace(), mergeUniforms(), WebGLBackground(), addToRenderList(), dispose(), getBackground() (+2 more)

### Community 166 - "addShape"
Cohesion: 0.31
Nodes (10): addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3(), f4(), getBevelVec() (+2 more)

### Community 167 - "WebP"
Cohesion: 0.20
Nodes (3): WorldPicture, WebP, Enabled

### Community 168 - "WebGLState"
Cohesion: 0.20
Nodes (18): WebGLState(), ColorBuffer(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), reset(), scissor() (+10 more)

### Community 169 - "oi"
Cohesion: 0.67
Nodes (4): Je(), ni(), oi(), si()

### Community 170 - "Preview"
Cohesion: 0.13
Nodes (5): Announce, Token, Pending, Preview, PreviewTests

### Community 171 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 174 - "m"
Cohesion: 0.31
Nodes (9): be(), De(), m(), p(), pe(), ve(), xe(), ye() (+1 more)

### Community 175 - "IEnumerator"
Cohesion: 0.09
Nodes (6): StaticCoroutine, StaticCoroutineRunner, ZoneSystemPatch, WorldEvents, InvasionsPath, StatePath

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
Cohesion: 0.22
Nodes (9): ForgeMap 1.2.0, bi(), e(), hi(), Pi(), q(), Qe(), Ti() (+1 more)

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 215 - "SerializedFile"
Cohesion: 0.20
Nodes (6): LeReader, MeshData, ObjectInfo, SerializedFile, Texture2D, TypeNode

## Knowledge Gaps
- **220 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+215 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1921 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **64 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `EventDispatcher`, `Func`, `Fact`, `HashSet`, `Portals`, `AuthTests`, `MapDataServer`, `Changelog`, `IEnumerator`, `TerrainPatches`, `Trails`, `WorldObjects`, `View3D`, `Deeds`, `Features`?**
  _High betweenness centrality (0.356) - this node is a cross-community bridge._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _220 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007839669908635426 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `EventDispatcher` to `three.core.js`, `three.module.js`, `Stats`?**
  _High betweenness centrality (0.306) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.008260415306255714 - nodes in this community are weakly interconnected._
- **Why does `initGLContext()` connect `.constructor` to `push`, `WebGLBindingStates`, `addToRenderList`, `.constructor`, `playercard.js`, `PMREMGenerator`, `WebGLState`, `update`, `get`?**
  _High betweenness centrality (0.069) - this node is a cross-community bridge._
- **Should `.push` be split into smaller, more focused modules?**
  _Cohesion score 0.03947583947583948 - nodes in this community are weakly interconnected._