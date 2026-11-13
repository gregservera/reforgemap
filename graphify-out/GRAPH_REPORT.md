# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 204 files · ~700,212 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6581 nodes · 15810 edges · 236 communities (155 shown, 81 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 746 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `32fa8ca3`
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
- BatchedMesh
- Vehicles
- ui.js
- .Export
- View3D
- Structures
- OrbitControls
- BufferAttribute
- List
- .Sweep
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
- .applyMatrix4
- .constructor
- Vector2
- playercard.js
- ZDOID
- JsonWriter
- Vegetation
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
- Loader
- WebGLProgram
- HashSet
- SerializedFile
- GLTFParser
- Fact
- MigrationTests
- RuinsGL
- RaidLayer
- WebMap
- web/js/view3d.js
- Matrix3
- WebGLBindingStates
- BundleFile
- package.json
- .getContext
- Path
- BiomeMap
- Heights
- Using the map
- ChunkShapes
- PropertyMixer
- .load
- toLatLng
- MeshDecoder
- Hand
- GroundGL
- ObjectLoader
- Changelog
- WorldEvents
- IEnumerator
- TerrainPatches
- arraysEqual
- .LookJson
- map-core.test.mjs
- Locations
- TileMath
- BuildingsGL
- ShapesCanvas
- particles.js
- WithDir
- ContourGL
- .load
- AnimationClip
- CubicBezierCurve
- OrbitControls.js
- .AnyExplored
- Material
- .build
- addToRenderList
- BufferGeometryUtils.js
- LightShadow
- QuadraticBezierCurve
- Png
- Français
- i18n.js
- PerspectiveCamera
- Interpolant
- PolyhedronGeometry
- InterleavedBuffer
- ForestMap
- DataTexture
- RenderTarget
- portrait.js
- TreesGL
- check.mjs
- onTouchMove
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
- Timer
- Layers
- VideoTexture
- WebGLShaderCache
- WebP
- AltBiomeGL
- BiomeGL
- GuideGL
- addShape
- ServerLog
- Shape
- PositionalAudio
- Demisters
- m
- EllipseCurve
- CompressedTexture
- Spherical
- WebMap.Tests.csproj
- WebMap.csproj
- .update
- Window
- render
- fetchTerrarium
- FogGL
- .parse
- Cylindrical
- GLBufferAttribute
- MeshCache
- flatten
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- AudioListener
- .FromSerialized
- .NewWorld
- MeshPhysicalMaterial
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- Controls
- LineCurve
- .Start
- bi
- Third-party notices
- .load
- .load
- InstancedBufferGeometry
- TextureUtils
- Clock
- testserver.sh
- allocateTextureUnit
- MultiDrawRenderList
- Uniform
- layers.js
- Fog
- CubicPoly
- getKeyframeOrder
- Int16BufferAttribute
- Int32BufferAttribute
- Int8BufferAttribute
- probeAsync
- Uint16BufferAttribute
- Uint32BufferAttribute
- Uint8BufferAttribute
- Uint8ClampedBufferAttribute
- FogExp2
- _points
- .lerp
- RawShaderMaterial

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

## Communities (236 total, 81 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (219): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+211 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (31): _cache, InterpolationSamplingMode, InterpolationSamplingType, TOUCH, arrayCacheF32, arrayCacheI32, _axisDirections, _clearColor (+23 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (37): AxesHelper, Box3Helper, buildPlane(), BufferGeometry, CameraHelper, addLine(), addPoint(), CapsuleGeometry (+29 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (78): chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM, TILE (+70 more)

### Community 4 - ".copy"
Cohesion: 0.04
Nodes (13): a(), c(), handleTriangle(), handleVertex(), checkGeometryIntersection(), checkIntersection$1(), isUniqueEdge(), Line3 (+5 more)

### Community 5 - "Object3D"
Cohesion: 0.03
Nodes (12): Camera, cloneUniformsGroups(), CubeCamera, DirectionalLight, FrustumArray, HemisphereLightHelper, Mesh, Object3D (+4 more)

### Community 6 - "Vector3"
Cohesion: 0.04
Nodes (12): applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs(), getVertexByIndex(), inclination() (+4 more)

### Community 7 - "BatchedMesh"
Cohesion: 0.06
Nodes (6): ascIdSort(), BatchedMesh, convertBufferAttribute(), copyArrayContents(), flattenJSON(), sortedArray()

### Community 8 - "Vehicles"
Cohesion: 0.08
Nodes (10): Entry, Graves, Entry, Traders, Entry, Kind, Boat, Cart (+2 more)

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (53): OBJECT_CATS, escape(), BIOME_SVG, breakable(), BUILD_SVG, BUSH_SVG, busyChart(), CONTOUR_SVG (+45 more)

### Community 10 - ".Export"
Cohesion: 0.07
Nodes (10): GlbWriter, Count, Node, Primitive, Skin, PrefabExporter, Result, Part (+2 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (13): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+5 more)

### Community 12 - "Structures"
Cohesion: 0.06
Nodes (20): ChunkCache, Line, Chunk, Ruins, IndexJson, LastChanged, Total, Site (+12 more)

### Community 13 - "OrbitControls"
Cohesion: 0.11
Nodes (4): onMouseDown(), onMouseWheel(), onPointerDown(), OrbitControls

### Community 14 - "BufferAttribute"
Cohesion: 0.05
Nodes (8): BufferAttribute, copyAttributeData(), createColorManagement(), DataUtils, denormalize(), Float16BufferAttribute, InterleavedBufferAttribute, _createPlanes()

### Community 15 - "List"
Cohesion: 0.16
Nodes (6): Peak, Peaks, All, Kind, Runestones, Stone

### Community 16 - ".Sweep"
Cohesion: 0.07
Nodes (10): Chart, Fnv, Entry, Kind, Pieces, Cell, StructureMap, Floor (+2 more)

### Community 17 - "WebGLRenderer"
Cohesion: 0.08
Nodes (8): WebGLRenderTarget, WebGLRenderer, renderTransmissionPass(), VSMPass(), onAnimationFrame(), onInputSourcesChange(), onSessionEnd(), onSessionEvent()

### Community 18 - "Markers"
Cohesion: 0.06
Nodes (12): BaseOverride, BedSpot, Findable, Markers, Json, Rev, PartTimer, Portal (+4 more)

### Community 19 - "markers.js"
Cohesion: 0.07
Nodes (28): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), iconSvg(), byName() (+20 more)

### Community 20 - "Dictionary"
Cohesion: 0.11
Nodes (13): Info, ModelStore, Exported, MeshesPresent, MeshesWanted, PrefabsJson, QueueLength, Readable (+5 more)

### Community 21 - ".start"
Cohesion: 0.09
Nodes (6): App, BiomeHover, fromLatLng(), esc(), ForgeCard, T()

### Community 22 - "WebGLState"
Cohesion: 0.18
Nodes (19): WebGLState(), activeTexture(), ColorBuffer(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), reset() (+11 more)

### Community 23 - "Stats"
Cohesion: 0.09
Nodes (8): What a regression would do on the live server, worst first, Boss, D, Kit, Spot, Standing, Stats, StatsTests

### Community 24 - "update"
Cohesion: 0.06
Nodes (48): arrayNeedsUint32(), warnOnce(), WebGLAttributes(), createBuffer(), get(), remove(), update(), updateBuffer() (+40 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.09
Nodes (16): MapFog, Revision, ParticleSystem, ThreeDTests, Cat, Bush, Other, Piece (+8 more)

### Community 27 - "get"
Cohesion: 0.08
Nodes (67): createElementNS(), getByteLength(), getTextureTypeByteLength(), WebGLCapabilities(), getMaxAnisotropy(), textureFormatReadable(), textureTypeReadable(), WebGLProperties() (+59 more)

### Community 29 - "measure.js"
Cohesion: 0.06
Nodes (16): rgb(), WorldEdgeGL, BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool (+8 more)

### Community 30 - "system"
Cohesion: 0.05
Nodes (8): WebMap.Models.Unity, WebMap.Util, WebMap, WebMap.Tests, WebMap.Models, WebMap.Tiles, Setup, StaticFilesTests

### Community 31 - "Features"
Cohesion: 0.10
Nodes (5): Testing, Feature, Features, Grids, Named

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

### Community 37 - ".applyMatrix4"
Cohesion: 0.04
Nodes (9): Box2, BoxHelper, checkIntersection(), Frustum, InstancedBufferAttribute, InstancedMesh, LOD, Sphere (+1 more)

### Community 38 - ".constructor"
Cohesion: 0.16
Nodes (21): WebGLMaterials(), refreshFogUniforms(), refreshMaterialUniforms(), refreshTransformUniform(), refreshUniformsCommon(), refreshUniformsDash(), refreshUniformsDistance(), refreshUniformsLine() (+13 more)

### Community 40 - "playercard.js"
Cohesion: 0.07
Nodes (30): ChunkStore, RegionLoader, RuinsLayer, RuinStore, getJSON(), activityHtml(), ARMOR_SLOTS, at() (+22 more)

### Community 41 - "ZDOID"
Cohesion: 0.06
Nodes (24): Deeds, DeedsGonePatch, DeedsRoutePatch, Kind, Kill, Rock, Tree, Last (+16 more)

### Community 43 - "Vegetation"
Cohesion: 0.15
Nodes (7): Class, Crunched, Point, Vegetation, LastRocks, LastTrees, ZoneCount

### Community 44 - "leaflet.js"
Cohesion: 0.06
Nodes (37): Ae(), at(), Ci(), d(), ei(), F(), G(), h() (+29 more)

### Community 45 - "Matrix4"
Cohesion: 0.03
Nodes (13): Bone, CatmullRomCurve3, DirectionalLightHelper, Line, LineLoop, makeClipAdditive(), Matrix2, Matrix4 (+5 more)

### Community 46 - "WebXRController"
Cohesion: 0.10
Nodes (3): Group, UniformsGroup, WebXRController

### Community 47 - "Vector3"
Cohesion: 0.08
Nodes (14): Dungeons, Signature, Inside, Visited, Kind, Chest, Gate, Generator (+6 more)

### Community 48 - "AuthTests"
Cohesion: 0.14
Nodes (3): Auth, Session, AuthTests

### Community 49 - ".constructor"
Cohesion: 0.12
Nodes (6): ArrowHelper, ConeGeometry, CylinderGeometry, MeshBasicMaterial, PointLightHelper, SphereGeometry

### Community 50 - ".equals"
Cohesion: 0.07
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebXRManager"
Cohesion: 0.07
Nodes (9): PlaneGeometry, WebGLAnimation(), onAnimationFrame(), onAnimationFrame(), WebXRDepthSensing, WebXRManager, setProjectionFromUnion(), updateCamera() (+1 more)

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "FogLayer"
Cohesion: 0.08
Nodes (14): ObjectStore, parseVeg(), VegStore, FogLayer, connect(), emit(), evKey(), fetchEarly() (+6 more)

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "GateTests"
Cohesion: 0.09
Nodes (3): Given, GateTests, LightModeTests

### Community 57 - ".parseObject"
Cohesion: 0.08
Nodes (7): AmbientLight, HemisphereLight, Light, LightProbe, PointLight, PointLightShadow, RectAreaLight

### Community 58 - "Color"
Cohesion: 0.09
Nodes (3): Color, hue2rgb(), LinearToSRGB()

### Community 61 - ".constructor"
Cohesion: 0.09
Nodes (34): createCanvasElement(), WebGLCubeMaps(), get(), mapTextureMapping(), onTextureDispose(), WebGLCubeUVMaps(), dispose(), get() (+26 more)

### Community 62 - "TileStore"
Cohesion: 0.11
Nodes (7): TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered, RenderMsTotal

### Community 63 - "markercanvas.js"
Cohesion: 0.11
Nodes (12): asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache, labelImage() (+4 more)

### Community 64 - "Euler"
Cohesion: 0.08
Nodes (7): Euler, MeshLambertMaterial, MeshPhongMaterial, MeshStandardMaterial, onQuaternionChange(), onRotationChange(), Scene

### Community 65 - "push"
Cohesion: 0.08
Nodes (30): ExternalTexture, shadowCastingAndTexturingLightsFirst(), ShadowUniformsCache(), UniformsCache(), WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLLights() (+22 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.12
Nodes (8): ChatCommands, Command, Kind, Delete, None, Pin, Undo, ChatCommandsTests

### Community 68 - "Discord"
Cohesion: 0.08
Nodes (9): Body, ChatRelay, Discord, Token, DiscordMessage, DiscordRef, Result, ChatRelayTests (+1 more)

### Community 70 - "TileJob"
Cohesion: 0.13
Nodes (9): Palette, Rgb, TileJob, ColorImage, HeightPng, SampledRows, TerraImage, VegImage (+1 more)

### Community 71 - "Curve"
Cohesion: 0.10
Nodes (4): CatmullRom(), Curve, LineCurve3, SplineCurve

### Community 72 - "PMREMGenerator"
Cohesion: 0.16
Nodes (8): ShaderMaterial, _createRenderTarget(), _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial(), PMREMGenerator, _setViewport()

### Community 73 - "Feed"
Cohesion: 0.13
Nodes (6): Ev, Feed, Keep, RecentJson, FeedTests, JsonParser

### Community 74 - "Texture"
Cohesion: 0.08
Nodes (5): CanvasTexture, DepthTexture, FramebufferTexture, Source, Texture

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
Cohesion: 0.11
Nodes (6): BooleanKeyframeTrack, ColorKeyframeTrack, KeyframeTrack, QuaternionKeyframeTrack, StringKeyframeTrack, VectorKeyframeTrack

### Community 79 - "Items"
Cohesion: 0.15
Nodes (3): Items, Ready, ItemsTests

### Community 80 - "MapDataServer"
Cohesion: 0.08
Nodes (4): MapDataServer, PlayersWs, MapMessage, WebSocketHandler

### Community 81 - ".assignTexture"
Cohesion: 0.06
Nodes (8): GLTFMaterialsAnisotropyExtension, GLTFMaterialsBumpExtension, GLTFMaterialsIridescenceExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "Func"
Cohesion: 0.14
Nodes (5): Entry, Settings, Live, Stats, WorldEvents

### Community 83 - "LoadingManager"
Cohesion: 0.11
Nodes (6): EventDispatcher, ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), LoadingManager

### Community 84 - "JsonElement"
Cohesion: 0.16
Nodes (5): Entry, Last, Portals, PortalsTests, J

### Community 86 - "Loader"
Cohesion: 0.11
Nodes (7): AudioLoader, BufferGeometryLoader, CubeTextureLoader, DataTextureLoader, ImageLoader, Loader, TextureLoader

### Community 87 - "WebGLProgram"
Cohesion: 0.08
Nodes (25): fetchAttributeLocations(), filterEmptyLine(), generateCubeUVSize(), generateDefines(), generateEnvMapBlendingDefine(), generateEnvMapModeDefine(), generateEnvMapTypeDefine(), generatePrecision() (+17 more)

### Community 88 - "HashSet"
Cohesion: 0.15
Nodes (8): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running

### Community 89 - "SerializedFile"
Cohesion: 0.22
Nodes (5): LeReader, ObjectInfo, SerializedFile, TypeInfo, TypeNode

### Community 90 - "GLTFParser"
Cohesion: 0.19
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.11
Nodes (5): FeaturesTests, SettingsTests, Grid, Cell, TilesTests

### Community 92 - "MigrationTests"
Cohesion: 0.14
Nodes (7): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins, VersionTests

### Community 93 - "RuinsGL"
Cohesion: 0.12
Nodes (5): hexRgb(), materialRgb(), PackedRegions, packRects(), RuinsGL

### Community 94 - "RaidLayer"
Cohesion: 0.18
Nodes (5): MapCore, ago(), areaCache, areaImage(), RaidLayer

### Community 95 - "WebMap"
Cohesion: 0.07
Nodes (11): DeathWatch, DiscordWebHook, Ping, WebMap, ZNetPatchDisconnect, ZNetPatchSetServer, ZNetPatchStart, ZoneSystemLoadPatch (+3 more)

### Community 96 - "web/js/view3d.js"
Cohesion: 0.13
Nodes (13): Street, _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), fallbackColor() (+5 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.17
Nodes (21): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+13 more)

### Community 99 - "BundleFile"
Cohesion: 0.14
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - ".getContext"
Cohesion: 0.20
Nodes (4): AudioContext, ImageUtils, serializeImage(), SRGBToLinear()

### Community 104 - "Heights"
Cohesion: 0.19
Nodes (5): Heights, KeepSamples, Job, Served, Job

### Community 105 - "Using the map"
Cohesion: 0.10
Nodes (20): Chat commands, Checking the viewer against a live server, Coming from WebMap, Configuration, Discord, Features, Full-quality textures (optional), Install (+12 more)

### Community 108 - ".load"
Cohesion: 0.23
Nodes (5): handleError(), CompressedTextureLoader, loadTexture(), loadTexture(), FileLoader

### Community 110 - "MeshDecoder"
Cohesion: 0.23
Nodes (3): Decoded, MeshDecoder, P

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.22
Nodes (3): GroundGL, perSide(), span()

### Community 114 - "Changelog"
Cohesion: 0.10
Nodes (18): 2.11.0, 2.14.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0, Changelog (+10 more)

### Community 115 - "WorldEvents"
Cohesion: 0.17
Nodes (4): SkipToMorningPatch, WorldEvents, InvasionsPath, StatePath

### Community 116 - "IEnumerator"
Cohesion: 0.13
Nodes (4): LocationTerrain, Count, Mod, Patch

### Community 117 - "TerrainPatches"
Cohesion: 0.26
Nodes (3): Patch, TerrainPatches, Count

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

### Community 125 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 126 - "WithDir"
Cohesion: 0.11
Nodes (6): HdMaps, HdMapsTests, Sink, PinsTests, File_, WithDir

### Community 127 - "ContourGL"
Cohesion: 0.17
Nodes (4): ContourGL, labelImage(), span(), screenArea()

### Community 128 - ".load"
Cohesion: 0.20
Nodes (3): GLTFTextureAVIFExtension, GLTFTextureBasisUExtension, GLTFTextureWebPExtension

### Community 129 - "AnimationClip"
Cohesion: 0.14
Nodes (3): AnimationClip, AnimationUtils, NumberKeyframeTrack

### Community 130 - "CubicBezierCurve"
Cohesion: 0.12
Nodes (7): CubicBezier(), CubicBezierCurve, CubicBezierCurve3, CubicBezierP0(), CubicBezierP1(), CubicBezierP2(), CubicBezierP3()

### Community 131 - "OrbitControls.js"
Cohesion: 0.11
Nodes (11): PlayerCard, MapControls, _changeEvent, _endEvent, onPointerUp(), _plane, _ray, _startEvent (+3 more)

### Community 133 - "Material"
Cohesion: 0.12
Nodes (16): Material, Ashwood, BlackMarble, Cloth, CoreWood, Crystal, DarkWood, Fire (+8 more)

### Community 134 - ".build"
Cohesion: 0.23
Nodes (3): drawPicture(), renderTarget(), ShapeCache

### Community 135 - "addToRenderList"
Cohesion: 0.15
Nodes (11): BoxGeometry, cloneUniforms(), getUnlitUniformColorSpace(), mergeUniforms(), WebGLCubeRenderTarget, WebGLBackground(), addToRenderList(), dispose() (+3 more)

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

### Community 137 - "LightShadow"
Cohesion: 0.10
Nodes (4): DirectionalLightShadow, LightShadow, OrthographicCamera, SpotLightShadow

### Community 138 - "QuadraticBezierCurve"
Cohesion: 0.12
Nodes (6): QuadraticBezier(), QuadraticBezierCurve, QuadraticBezierCurve3, QuadraticBezierP0(), QuadraticBezierP1(), QuadraticBezierP2()

### Community 139 - "Png"
Cohesion: 0.19
Nodes (6): Format, Gray16, Gray8, RGB, RGBA, Png

### Community 140 - "Français"
Cohesion: 0.12
Nodes (13): Ce que tu vois sur la carte, Credits / Crédits, English, For the server admin, ForgeMap, Français, Install, Installation (+5 more)

### Community 141 - "i18n.js"
Cohesion: 0.17
Nodes (7): Gear, fill(), has(), num(), t(), tn(), translateTree()

### Community 143 - "Interpolant"
Cohesion: 0.17
Nodes (4): CubicInterpolant, DiscreteInterpolant, Interpolant, LinearInterpolant

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 145 - "InterleavedBuffer"
Cohesion: 0.14
Nodes (3): generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer

### Community 146 - "ForestMap"
Cohesion: 0.14
Nodes (8): Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump, Tree

### Community 147 - "DataTexture"
Cohesion: 0.16
Nodes (9): 2.9.1, getArrayBuffer(), getInterleavedBuffer(), DataTexture, getTypedArray(), intersect(), deserializeImage(), loadImage() (+1 more)

### Community 148 - "RenderTarget"
Cohesion: 0.11
Nodes (7): CubeTexture, Data3DTexture, DataArrayTexture, RenderTarget, RenderTarget3D, WebGL3DRenderTarget, WebGLArrayRenderTarget

### Community 149 - "portrait.js"
Cohesion: 0.26
Nodes (11): bodyTexture(), curlNoise(), finish(), image(), info(), lib(), model(), models (+3 more)

### Community 151 - "check.mjs"
Cohesion: 0.32
Nodes (11): [BASE, PORT, OUT], check(), map(), open(), plan(), players(), portals(), sleep() (+3 more)

### Community 153 - "parseUniform"
Cohesion: 0.17
Nodes (7): addUniform(), getPureArraySetter(), getSingularSetter(), parseUniform(), PureArrayUniform, SingleUniform, StructuredUniform

### Community 154 - "bench.mjs"
Cohesion: 0.22
Nodes (10): 2.12.0, [BASE, PORT], errors, ev(), ms(), pending, send(), tab (+2 more)

### Community 159 - "SmoothZoom"
Cohesion: 0.36
Nodes (3): SmoothZoom, SmoothZoomControl, update()

### Community 160 - "vegpack.js"
Cohesion: 0.23
Nodes (10): packTrees(), radiusOf(), RGB, seedOf(), SMALL_R, TREE_STRIDE, unpackRegion(), VEG (+2 more)

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 164 - "Layers"
Cohesion: 0.12
Nodes (4): ascSort(), Layers, Raycaster, StereoCamera

### Community 166 - "WebGLShaderCache"
Cohesion: 0.20
Nodes (5): getMaxPrecision(), getChannel(), getParameters(), WebGLShaderCache, WebGLShaderStage

### Community 170 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

### Community 171 - "addShape"
Cohesion: 0.27
Nodes (11): addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3(), f4(), getBevelVec() (+3 more)

### Community 172 - "ServerLog"
Cohesion: 0.16
Nodes (4): Line, ServerLog, Trails, ZNetPatchShutdown

### Community 175 - "Demisters"
Cohesion: 0.15
Nodes (4): Announce, Token, Pending, Demisters

### Community 176 - "m"
Cohesion: 0.21
Nodes (13): be(), De(), Je(), m(), ni(), oi(), p(), pe() (+5 more)

### Community 178 - "CompressedTexture"
Cohesion: 0.25
Nodes (3): CompressedArrayTexture, CompressedCubeTexture, CompressedTexture

### Community 180 - "WebMap.Tests.csproj"
Cohesion: 0.29
Nodes (5): net10.0, Microsoft.NET.Test.Sdk (17.14.1), xunit (2.9.3), xunit.runner.visualstudio (3.1.4), Microsoft.NET.Sdk

### Community 181 - "WebMap.csproj"
Cohesion: 0.29
Nodes (6): net48, ILRepack.Lib.MSBuild.Task (2.0.44.2), Krafs.Publicizer (2.2.1), Microsoft.NETFramework.ReferenceAssemblies (1.0.3), SixLabors.ImageSharp (2.1.13), Microsoft.NET.Sdk

### Community 184 - "render"
Cohesion: 0.43
Nodes (4): load(), message(), render(), Spot

### Community 185 - "fetchTerrarium"
Cohesion: 0.48
Nodes (4): decodePng(), fetchTerrarium(), tile(), tiles

### Community 187 - ".parse"
Cohesion: 0.29
Nodes (3): AnimationLoader, getTrackTypeForValueTypeName(), parseKeyframeTrack()

### Community 191 - "flatten"
Cohesion: 0.29
Nodes (7): flatten(), setValueM2Array(), setValueM3Array(), setValueM4Array(), setValueV2fArray(), setValueV3fArray(), setValueV4fArray()

### Community 192 - "ForgeMap — translation brief (read fully before editing)"
Cohesion: 0.33
Nodes (5): ForgeMap — translation brief (read fully before editing), French style (ForgeServer house style), Report back, The API (already written: `WebMap/web/js/i18n.js`, loaded first on every page), What you do, for each file assigned to you

### Community 193 - "manifest.json"
Cohesion: 0.33
Nodes (5): dependencies, description, name, version_number, website_url

### Community 196 - ".NewWorld"
Cohesion: 0.12
Nodes (6): 2.10.0, WebMapConfig, HeightMaxZoom, ImageConv, Texture2D, ZoneSystemPatch

### Community 203 - "bi"
Cohesion: 0.22
Nodes (9): ForgeMap 1.2.0, bi(), e(), hi(), Pi(), q(), Qe(), Ti() (+1 more)

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 211 - "allocateTextureUnit"
Cohesion: 0.40
Nodes (5): setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), allocateTextureUnit()

## Knowledge Gaps
- **214 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+209 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1905 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **81 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `Timer`, `Discord`, `ZDOID`, `ServerLog`, `View3D`, `AuthTests`, `.Sweep`, `ForestMap`, `MapDataServer`, `JsonElement`, `TerrainPatches`, `Changelog`, `WorldObjects`, `Features`, `WebMap`?**
  _High betweenness centrality (0.334) - this node is a cross-community bridge._
- **Are the 7 inferred relationships involving `get()` (e.g. with `WebGLAttributes()` and `WebGLCubeMaps()`) actually correct?**
  _`get()` has 7 INFERRED edges - model-reasoned connections that need verification._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _214 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.008 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `Timer` to `three.core.js`, `three.module.js`, `LoadingManager`, `Stats`?**
  _High betweenness centrality (0.276) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.008298755186721992 - nodes in this community are weakly interconnected._
- **Why does `initGLContext()` connect `.constructor` to `push`, `WebGLBindingStates`, `.constructor`, `addToRenderList`, `portrait.js`, `WebGLState`, `update`, `get`?**
  _High betweenness centrality (0.082) - this node is a cross-community bridge._