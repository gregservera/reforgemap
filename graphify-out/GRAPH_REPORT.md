# Graph Report - forgemap  (2026-11-13)

## Corpus Check
- 208 files · ~704,820 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 10 file(s) not represented in the graph (top: .css 4, (none) 2, .targets 1)

## Summary
- 6615 nodes · 15921 edges · 223 communities (157 shown, 66 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 761 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `b0928a52`
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
- .Finish
- ui.js
- .Export
- View3D
- Ruins
- OrbitControls
- BufferAttribute
- List
- .parseObject
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
- ChunkShapes
- leaflet.js
- Vehicles
- WebXRController
- .Sweep
- AuthTests
- .constructor
- .equals
- WebXRManager
- Vector4
- Veg
- FogLayer
- PropertyBinding
- GateTests
- Light
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
- OrbitControls.js
- WebGLProgram
- HashSet
- SerializedFile
- GLTFParser
- Fact
- MigrationTests
- RuinsGL
- RaidLayer
- BuildingsGL
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
- ShapesCanvas
- PropertyMixer
- Loader
- toLatLng
- MeshDecoder
- Hand
- GroundGL
- TreesGL
- Changelog
- WorldEvents
- TerrainPatches
- Structures
- arraysEqual
- .LookJson
- map-core.test.mjs
- Locations
- .build
- Deeds
- .applyMatrix4
- particles.js
- portrait.js
- ContourGL
- .load
- AnimationClip
- CubicBezierCurve
- onTouchMove
- Fact
- Material
- get
- .update
- BufferGeometryUtils.js
- CurvePath
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
- AltBiomeGL
- GlbWriter
- check.mjs
- ChatRelay
- parseUniform
- bench.mjs
- TextureDecoder
- .canopyMaterial
- MistGL
- FallbackTileLayer
- SmoothZoom
- vegpack.js
- .parse
- addShape
- GuideGL
- MeshCache
- VideoTexture
- WebGLShaderCache
- WebP
- Regex
- BiomeGL
- Preview
- d
- ServerLog
- Shape
- Kind
- ZNetPeer
- m
- EllipseCurve
- FogGL
- Spherical
- WebMap.Tests.csproj
- WebMap.csproj
- CylinderGeometry
- Window
- render
- fetchTerrarium
- GLTFMaterialsDispersionExtension
- Cylindrical
- GLBufferAttribute
- _points
- flatten
- ForgeMap — translation brief (read fully before editing)
- manifest.json
- Int16BufferAttribute
- Uint16BufferAttribute
- .NewWorld
- MeshPhysicalMaterial
- GLTFCubicSplineInterpolant
- GLTFLightsExtension
- Uint32BufferAttribute
- Uint8BufferAttribute
- .Start
- bi
- Third-party notices
- Uint8ClampedBufferAttribute
- .load
- InstancedBufferGeometry
- TextureUtils
- testserver.sh
- allocateTextureUnit
- MultiDrawRenderList
- Uniform
- layers.js
- Cat
- probeAsync
- worldkeys.js

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

## Communities (223 total, 66 thin omitted)

### Community 0 - "three.core.js"
Cohesion: 0.01
Nodes (222): _addedEvent, _alignedPosition, _axis, _basePosition, _batchIntersects, _boneMatrix, _box, _box$1 (+214 more)

### Community 1 - "three.module.js"
Cohesion: 0.01
Nodes (35): _cache, ColorManagement, DefaultLoadingManager, MOUSE, TimestampQuery, TOUCH, UniformsUtils, arrayCacheF32 (+27 more)

### Community 2 - ".push"
Cohesion: 0.03
Nodes (38): AxesHelper, Box3Helper, buildPlane(), BoxHelper, BufferGeometry, CameraHelper, addLine(), addPoint() (+30 more)

### Community 3 - "app.js"
Cohesion: 0.04
Nodes (78): chunkOf(), chunksOneZoomOut(), MAX_ZOOM, metersPerPixel(), OUTSIDE_COLOR, OUTSIDE_RIM, OVER_ZOOM, TILE (+70 more)

### Community 4 - ".copy"
Cohesion: 0.04
Nodes (12): a(), c(), handleTriangle(), handleVertex(), checkGeometryIntersection(), cloneUniformsGroups(), Line3, Plane (+4 more)

### Community 5 - "Object3D"
Cohesion: 0.03
Nodes (9): Camera, CubeCamera, DirectionalLightHelper, DirectionalLightShadow, Matrix4, Object3D, OrthographicCamera, SpotLightHelper (+1 more)

### Community 6 - "Vector3"
Cohesion: 0.03
Nodes (16): onQuaternionChange(), onRotationChange(), applyRadius(), azimuth(), correctSeam(), correctUV(), correctUVs(), generateUVs() (+8 more)

### Community 7 - "BatchedMesh"
Cohesion: 0.05
Nodes (9): ascIdSort(), BatchedMesh, Bone, CatmullRomCurve3, copyArrayContents(), flattenJSON(), Matrix2, Skeleton (+1 more)

### Community 8 - ".Finish"
Cohesion: 0.06
Nodes (17): Cell, ForestMap, LastStumps, LastTrees, Kind, Other, Stump, Tree (+9 more)

### Community 9 - "ui.js"
Cohesion: 0.05
Nodes (58): iconSvg(), escape(), makeIcon(), statsHtml(), BIOME_SVG, breakable(), BUILD_SVG, BUSH_SVG (+50 more)

### Community 11 - "View3D"
Cohesion: 0.06
Nodes (13): DAY, DUSK, lerp(), Lighting, NIGHT, smooth(), farSkip(), keyOf() (+5 more)

### Community 12 - "Ruins"
Cohesion: 0.06
Nodes (12): LocationTerrain, Count, Mod, Patch, Regions, Class, Crunched, Point (+4 more)

### Community 13 - "OrbitControls"
Cohesion: 0.11
Nodes (4): onMouseDown(), onMouseWheel(), onPointerDown(), OrbitControls

### Community 14 - "BufferAttribute"
Cohesion: 0.04
Nodes (10): BufferAttribute, convertBufferAttribute(), copyAttributeData(), createColorManagement(), DataUtils, denormalize(), Float16BufferAttribute, InterleavedBufferAttribute (+2 more)

### Community 15 - "List"
Cohesion: 0.15
Nodes (6): Peak, Peaks, All, Kind, Runestones, Stone

### Community 16 - ".parseObject"
Cohesion: 0.06
Nodes (15): 2.9.1, getArrayBuffer(), getInterleavedBuffer(), DataTexture, Fog, FogExp2, getTypedArray(), LightProbe (+7 more)

### Community 17 - "WebGLRenderer"
Cohesion: 0.07
Nodes (19): WebGLRenderTarget, WebGLClipping(), projectPlanes(), resetGlobalState(), WebGLRenderer, renderObject(), renderObjects(), renderScene() (+11 more)

### Community 18 - "Markers"
Cohesion: 0.07
Nodes (11): BaseOverride, BedSpot, Findable, Markers, Json, Rev, PartTimer, Portal (+3 more)

### Community 19 - "markers.js"
Cohesion: 0.07
Nodes (24): adminKey(), canSignIn(), setAdminKey(), signIn(), whoami(), writeHeaders(), byName(), collator (+16 more)

### Community 20 - "Dictionary"
Cohesion: 0.11
Nodes (13): Info, ModelStore, Exported, MeshesPresent, MeshesWanted, PrefabsJson, QueueLength, Readable (+5 more)

### Community 21 - ".start"
Cohesion: 0.09
Nodes (9): App, BiomeHover, fromLatLng(), toLatLng(), esc(), ForgeCard, T(), weatherWord() (+1 more)

### Community 22 - "WebGLState"
Cohesion: 0.22
Nodes (17): WebGLState(), ColorBuffer(), compressedTexImage3D(), DepthBuffer(), disable(), enable(), reset(), scissor() (+9 more)

### Community 23 - "Stats"
Cohesion: 0.08
Nodes (9): What a regression would do on the live server, worst first, Boss, D, Kit, P, Spot, Standing, Stats (+1 more)

### Community 24 - "update"
Cohesion: 0.09
Nodes (31): warnOnce(), createBuffer(), WebGLBufferRenderer(), render(), renderInstances(), renderMultiDraw(), renderMultiDrawInstances(), WebGLExtensions() (+23 more)

### Community 25 - "textures-hd.py"
Cohesion: 0.06
Nodes (13): package.sh script, H, asset_files(), capped(), emission_png(), file_name(), main(), mr_png() (+5 more)

### Community 26 - "WorldObjects"
Cohesion: 0.12
Nodes (9): MapFog, Revision, ParticleSystem, ThreeDTests, Chunk, Obj, Rock, WorldObjects (+1 more)

### Community 27 - "get"
Cohesion: 0.10
Nodes (53): createElementNS(), getContext(), activeTexture(), bindFramebuffer(), bindTexture(), compressedTexImage2D(), compressedTexSubImage2D(), compressedTexSubImage3D() (+45 more)

### Community 29 - "measure.js"
Cohesion: 0.06
Nodes (16): rgb(), WorldEdgeGL, BAND_COLOURS, cache, fmtDist(), fmtMin(), fmtTime(), MeasureTool (+8 more)

### Community 30 - "system"
Cohesion: 0.05
Nodes (8): WebMap.Models.Unity, WebMap.Util, WebMap, WebMap.Tests, WebMap.Models, WebMap.Tiles, Setup, StaticFilesTests

### Community 31 - "Features"
Cohesion: 0.09
Nodes (6): Chart, Feature, Features, Grids, Named, Fnv

### Community 32 - "ForgeCanvas"
Cohesion: 0.06
Nodes (15): Tour, DeathsLayer, fogUsers, ForgeCanvas, loadFog(), MC, walkedFn(), PathsLayer (+7 more)

### Community 33 - "Audio"
Cohesion: 0.05
Nodes (4): Audio, AudioAnalyser, Controls, PositionalAudio

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
Cohesion: 0.07
Nodes (5): ascSort(), Box2, intersect(), Raycaster, Sphere

### Community 38 - ".constructor"
Cohesion: 0.12
Nodes (26): WebGLMaterials(), refreshFogUniforms(), refreshMaterialUniforms(), refreshTransformUniform(), refreshUniformsCommon(), refreshUniformsDash(), refreshUniformsDistance(), refreshUniformsLine() (+18 more)

### Community 40 - "playercard.js"
Cohesion: 0.13
Nodes (20): activityHtml(), ARMOR_SLOTS, at(), BIOME_COL, clock(), connHtml(), day(), dayLabel() (+12 more)

### Community 41 - "ZDOID"
Cohesion: 0.09
Nodes (15): Kind, Kitchen, Made, Brewed, Burnt, Cooked, Honey, Smelted (+7 more)

### Community 44 - "leaflet.js"
Cohesion: 0.06
Nodes (36): Ae(), be(), Ci(), De(), ei(), F(), G(), h() (+28 more)

### Community 45 - "Vehicles"
Cohesion: 0.13
Nodes (7): Entry, Traders, Kind, Boat, Cart, None, Vehicles

### Community 47 - ".Sweep"
Cohesion: 0.06
Nodes (11): Entry, Graves, Demisters, Dungeons, Signature, Inside, Visited, Placed (+3 more)

### Community 48 - "AuthTests"
Cohesion: 0.15
Nodes (3): Auth, Session, AuthTests

### Community 49 - ".constructor"
Cohesion: 0.07
Nodes (9): ArrowHelper, BoxGeometry, HemisphereLightHelper, Line, Mesh, MeshBasicMaterial, PlaneHelper, PointLightHelper (+1 more)

### Community 50 - ".equals"
Cohesion: 0.07
Nodes (34): addContour(), compareXYSlope(), createNode(), cureLocalIntersections(), earcut(), earcutLinked(), eliminateHole(), eliminateHoles() (+26 more)

### Community 51 - "WebXRManager"
Cohesion: 0.07
Nodes (12): cloneUniforms(), getUnlitUniformColorSpace(), mergeUniforms(), PlaneGeometry, WebGLBackground(), addToRenderList(), dispose(), getBackground() (+4 more)

### Community 52 - "Vector4"
Cohesion: 0.04
Nodes (3): LightShadow, PointLightShadow, Vector4

### Community 53 - "Veg"
Cohesion: 0.05
Nodes (40): Veg, AshFern, AshTree, AshVine, BarleyWild, Berry, Birch, BirchAutumn (+32 more)

### Community 54 - "FogLayer"
Cohesion: 0.05
Nodes (21): ChunkStore, ObjectStore, parseVeg(), RegionLoader, VegStore, FogLayer, RuinsLayer, RuinStore (+13 more)

### Community 55 - "PropertyBinding"
Cohesion: 0.06
Nodes (3): AnimationObjectGroup, Composite, PropertyBinding

### Community 56 - "GateTests"
Cohesion: 0.09
Nodes (3): Given, GateTests, LightModeTests

### Community 57 - "Light"
Cohesion: 0.06
Nodes (8): AmbientLight, DirectionalLight, HemisphereLight, Light, PointLight, RectAreaLight, SpotLight, SpotLightShadow

### Community 58 - "Color"
Cohesion: 0.07
Nodes (6): Color, damp(), euclideanModulo(), hue2rgb(), LinearToSRGB(), pingpong()

### Community 61 - ".constructor"
Cohesion: 0.12
Nodes (22): createCanvasElement(), WebGLAnimation(), onAnimationFrame(), acquireProgram(), releaseShaderCache(), remove(), deallocateMaterial(), getProgram() (+14 more)

### Community 62 - "TileStore"
Cohesion: 0.08
Nodes (9): TileMath, ChunksPerSide, TileStore, ClearTile, MainThreadSampling, OnDisk, QueueLength, Rendered (+1 more)

### Community 63 - "markercanvas.js"
Cohesion: 0.10
Nodes (13): colors, asDot(), badgeCache, countBadge(), gamePinImage(), iconCache, iconImage(), labelCache (+5 more)

### Community 64 - "Euler"
Cohesion: 0.09
Nodes (5): Euler, MeshLambertMaterial, MeshPhongMaterial, MeshStandardMaterial, Scene

### Community 65 - "push"
Cohesion: 0.11
Nodes (21): ExternalTexture, WebGLLights(), setup(), setupView(), getProgramCacheKey(), getProgramCacheKeyBooleans(), getProgramCacheKeyParameters(), checkMaterialsReady() (+13 more)

### Community 66 - "GLTFLoader.js"
Cohesion: 0.08
Nodes (26): addMorphTargets(), addPrimitiveAttributes(), assignAttributeAccessor(), ALPHA_MODES, ATTRIBUTES, BINARY_EXTENSION_CHUNK_TYPES, computeBounds(), createAttributesKey() (+18 more)

### Community 67 - "InlineData"
Cohesion: 0.11
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
Cohesion: 0.14
Nodes (9): RawShaderMaterial, ShaderMaterial, _createRenderTarget(), _getBlurShader(), _getCommonVertexShader(), _getCubemapMaterial(), _getEquirectMaterial(), PMREMGenerator (+1 more)

### Community 74 - "Texture"
Cohesion: 0.04
Nodes (16): CanvasTexture, CompressedArrayTexture, CompressedCubeTexture, CompressedTexture, CubeTexture, Data3DTexture, DataArrayTexture, DepthTexture (+8 more)

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
Cohesion: 0.12
Nodes (3): Items, Ready, ItemsTests

### Community 81 - ".assignTexture"
Cohesion: 0.07
Nodes (7): GLTFMaterialsAnisotropyExtension, GLTFMaterialsClearcoatExtension, GLTFMaterialsSheenExtension, GLTFMaterialsSpecularExtension, GLTFMaterialsTransmissionExtension, GLTFMaterialsVolumeExtension, GLTFTextureTransformExtension

### Community 82 - "Func"
Cohesion: 0.14
Nodes (5): Entry, Settings, Live, Stats, WorldEvents

### Community 83 - "LoadingManager"
Cohesion: 0.07
Nodes (8): EventDispatcher, handleVisibilityChange(), ImageBitmapLoader, onImageError(), onImageLoad(), removeEventListeners(), LoadingManager, Timer

### Community 84 - "JsonElement"
Cohesion: 0.20
Nodes (5): Testing, Entry, Last, Portals, PortalsTests

### Community 86 - "OrbitControls.js"
Cohesion: 0.11
Nodes (11): PlayerCard, MapControls, _changeEvent, _endEvent, onPointerUp(), _plane, _ray, _startEvent (+3 more)

### Community 87 - "WebGLProgram"
Cohesion: 0.08
Nodes (25): fetchAttributeLocations(), filterEmptyLine(), generateCubeUVSize(), generateDefines(), generateEnvMapBlendingDefine(), generateEnvMapModeDefine(), generateEnvMapTypeDefine(), generatePrecision() (+17 more)

### Community 88 - "HashSet"
Cohesion: 0.14
Nodes (8): MeshExtractor, LastFound, LastReport, Running, TextureExtractor, LastFound, LastReport, Running

### Community 89 - "SerializedFile"
Cohesion: 0.21
Nodes (6): LeReader, ObjectInfo, SerializedFile, Texture2D, TypeInfo, TypeNode

### Community 90 - "GLTFParser"
Cohesion: 0.20
Nodes (3): addUnknownExtensionsToUserData(), assignExtrasToUserData(), GLTFParser

### Community 91 - "Fact"
Cohesion: 0.15
Nodes (4): FeaturesTests, Grid, Cell, J

### Community 92 - "MigrationTests"
Cohesion: 0.18
Nodes (6): Migration, MigrationTests, Configs, NewCfg, OldCfg, Plugins

### Community 93 - "RuinsGL"
Cohesion: 0.12
Nodes (5): hexRgb(), materialRgb(), PackedRegions, packRects(), RuinsGL

### Community 94 - "RaidLayer"
Cohesion: 0.18
Nodes (5): MapCore, ago(), areaCache, areaImage(), RaidLayer

### Community 96 - "web/js/view3d.js"
Cohesion: 0.13
Nodes (13): Street, _ahead, AROUND, bigFromAfar(), checksum(), decodeObjects(), EDGES(), fallbackColor() (+5 more)

### Community 98 - "WebGLBindingStates"
Cohesion: 0.13
Nodes (22): WebGLBindingStates(), bindVertexArrayObject(), createBindingState(), createVertexArrayObject(), deleteVertexArrayObject(), disableUnusedAttributes(), dispose(), enableAttribute() (+14 more)

### Community 99 - "BundleFile"
Cohesion: 0.14
Nodes (5): BigEndianReader, Block, BundleFile, Node, Lz4

### Community 100 - "package.json"
Cohesion: 0.10
Nodes (20): CONFUSING, ES_MODULES, MODULES, MUNIN, rules, UNUSED, description, devDependencies (+12 more)

### Community 101 - "Clock"
Cohesion: 0.12
Nodes (5): AudioContext, AudioListener, Clock, ImageUtils, SRGBToLinear()

### Community 103 - "BiomeMap"
Cohesion: 0.13
Nodes (4): BiomeMap, Label, Now, Weather

### Community 104 - "Heights"
Cohesion: 0.19
Nodes (5): Heights, KeepSamples, Job, Served, Job

### Community 105 - "Using the map"
Cohesion: 0.11
Nodes (18): Chat commands, Checking the viewer against a live server, Configuration, Discord, Features, Full-quality textures (optional), Licence and credit, Local test server (+10 more)

### Community 108 - "Loader"
Cohesion: 0.09
Nodes (14): AnimationLoader, AudioLoader, handleError(), BufferGeometryLoader, CompressedTextureLoader, loadTexture(), CubeTextureLoader, loadTexture() (+6 more)

### Community 110 - "MeshDecoder"
Cohesion: 0.23
Nodes (3): Decoded, MeshDecoder, MeshData

### Community 111 - "Hand"
Cohesion: 0.10
Nodes (20): Hand, Axe, Bow, Crossbow, Cultivator, Fishing, Hammer, Hoe (+12 more)

### Community 112 - "GroundGL"
Cohesion: 0.22
Nodes (3): GroundGL, perSide(), span()

### Community 114 - "Changelog"
Cohesion: 0.12
Nodes (16): 2.10.0, 2.11.0, 2.14.0, 2.16.0, 2.16.1, 2.7.1 and earlier, 2.8.0, 2.9.0 (+8 more)

### Community 115 - "WorldEvents"
Cohesion: 0.16
Nodes (4): SkipToMorningPatch, WorldEvents, InvasionsPath, StatePath

### Community 116 - "TerrainPatches"
Cohesion: 0.20
Nodes (3): Patch, TerrainPatches, Count

### Community 117 - "Structures"
Cohesion: 0.06
Nodes (19): ChunkCache, Line, Chunk, Ruins, IndexJson, LastChanged, Total, Site (+11 more)

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

### Community 123 - "Deeds"
Cohesion: 0.14
Nodes (9): Deeds, DeedsGonePatch, DeedsRoutePatch, Kind, Kill, Rock, Tree, Last (+1 more)

### Community 124 - ".applyMatrix4"
Cohesion: 0.05
Nodes (9): checkIntersection(), checkIntersection$1(), Frustum, FrustumArray, InstancedBufferAttribute, InstancedMesh, LOD, SkinnedMesh (+1 more)

### Community 125 - "particles.js"
Cohesion: 0.22
Nodes (17): BLENDS(), born(), colour(), curve(), eulerZXY(), lerp4(), light(), makeEffects() (+9 more)

### Community 126 - "portrait.js"
Cohesion: 0.26
Nodes (11): bodyTexture(), curlNoise(), finish(), image(), info(), lib(), model(), models (+3 more)

### Community 127 - "ContourGL"
Cohesion: 0.17
Nodes (4): ContourGL, labelImage(), span(), screenArea()

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
Cohesion: 0.10
Nodes (6): GearTests, PinsTests, File_, SettingsTests, TilesTests, VersionTests

### Community 133 - "Material"
Cohesion: 0.12
Nodes (16): Material, Ashwood, BlackMarble, Cloth, CoreWood, Crystal, DarkWood, Fire (+8 more)

### Community 134 - "get"
Cohesion: 0.08
Nodes (39): renderTarget(), arrayNeedsUint32(), WebGLCubeRenderTarget, WebGLAttributes(), get(), remove(), update(), updateBuffer() (+31 more)

### Community 136 - "BufferGeometryUtils.js"
Cohesion: 0.15
Nodes (8): computeMikkTSpaceTangents(), computeMorphedAttributes(), deepCloneAttribute(), deinterleaveAttribute(), deinterleaveGeometry(), mergeAttributes(), mergeGeometries(), toCreasedNormals()

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

### Community 142 - "PerspectiveCamera"
Cohesion: 0.10
Nodes (4): ArrayCamera, Layers, PerspectiveCamera, StereoCamera

### Community 143 - "Interpolant"
Cohesion: 0.17
Nodes (4): CubicInterpolant, DiscreteInterpolant, Interpolant, LinearInterpolant

### Community 144 - "PolyhedronGeometry"
Cohesion: 0.13
Nodes (5): DodecahedronGeometry, IcosahedronGeometry, OctahedronGeometry, PolyhedronGeometry, TetrahedronGeometry

### Community 145 - "InterleavedBuffer"
Cohesion: 0.09
Nodes (4): generateUUID(), InstancedInterleavedBuffer, InterleavedBuffer, UniformsGroup

### Community 146 - "Feed"
Cohesion: 0.23
Nodes (5): Ev, Feed, Keep, RecentJson, FeedTests

### Community 147 - "Part"
Cohesion: 0.17
Nodes (4): Node, Part, Player, RigExporter

### Community 148 - "WebMap.cs"
Cohesion: 0.17
Nodes (4): DeathWatch, WebSocketHandler, ZRoutedRpcPatch, ZRoutedRpcRoutePatch

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

### Community 159 - "SmoothZoom"
Cohesion: 0.36
Nodes (3): SmoothZoom, SmoothZoomControl, update()

### Community 160 - "vegpack.js"
Cohesion: 0.23
Nodes (10): packTrees(), radiusOf(), RGB, seedOf(), SMALL_R, TREE_STRIDE, unpackRegion(), VEG (+2 more)

### Community 161 - ".parse"
Cohesion: 0.18
Nodes (3): GLTFBinaryExtension, GLTFMaterialsUnlitExtension, GLTFMeshQuantizationExtension

### Community 162 - "addShape"
Cohesion: 0.27
Nodes (11): addShape(), addUV(), addVertex(), buildLidFaces(), buildSideFaces(), f3(), f4(), getBevelVec() (+3 more)

### Community 163 - "GuideGL"
Cohesion: 0.22
Nodes (3): glyphAtlas(), GuideGL, textImage()

### Community 166 - "WebGLShaderCache"
Cohesion: 0.20
Nodes (6): WebGLPrograms(), dispose(), getChannel(), getParameters(), WebGLShaderCache, WebGLShaderStage

### Community 168 - "Regex"
Cohesion: 0.18
Nodes (4): HdMaps, HdMapsTests, Sink, WithDir

### Community 169 - "BiomeGL"
Cohesion: 0.22
Nodes (3): 2.13.0, bigText(), BiomeGL

### Community 171 - "d"
Cohesion: 0.25
Nodes (9): at(), d(), ht(), i(), Li(), Mi(), v(), W() (+1 more)

### Community 172 - "ServerLog"
Cohesion: 0.15
Nodes (4): Line, ServerLog, Trails, ZNetPatchShutdown

### Community 174 - "Kind"
Cohesion: 0.25
Nodes (8): Kind, Chest, Gate, Generator, Mining, Monster, None, Pickable

### Community 175 - "ZNetPeer"
Cohesion: 0.06
Nodes (12): Announce, Token, Pending, DiscordWebHook, MapMessage, Ping, WebMap, ZNetPatchDisconnect (+4 more)

### Community 176 - "m"
Cohesion: 0.24
Nodes (11): HTTP endpoints, look(), ct(), e(), hi(), m(), Qe(), ve() (+3 more)

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
Cohesion: 0.15
Nodes (3): WebMapConfig, HeightMaxZoom, ImageConv

### Community 202 - ".Start"
Cohesion: 0.18
Nodes (3): StaticCoroutine, StaticCoroutineRunner, ZoneSystemPatch

### Community 203 - "bi"
Cohesion: 0.33
Nodes (6): ForgeMap 1.2.0, bi(), Pi(), q(), Ti(), u()

### Community 204 - "Third-party notices"
Cohesion: 0.40
Nodes (4): Leaflet 1.9.4, SixLabors.ImageSharp 2.1.13, System.Buffers 4.5.1, System.Numerics.Vectors 4.5.0, System.Text.Encoding.CodePages 5.0.0, Third-party notices

### Community 211 - "allocateTextureUnit"
Cohesion: 0.40
Nodes (5): setValueT1(), setValueT2DArray1(), setValueT3D1(), setValueT6(), allocateTextureUnit()

### Community 215 - "Cat"
Cohesion: 0.29
Nodes (7): Cat, Bush, Other, Piece, Rock, Skip, Tree

## Knowledge Gaps
- **214 isolated node(s):** `Plugins`, `Configs`, `NewCfg`, `OldCfg`, `File_` (+209 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 1908 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **66 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `What a regression would do on the live server, worst first` connect `Stats` to `Discord`, `.Finish`, `ServerLog`, `ZNetPeer`, `AuthTests`, `MapDataServer`, `Changelog`, `LoadingManager`, `WebMap.cs`, `JsonElement`, `TerrainPatches`, `ChatRelay`, `WorldObjects`, `Deeds`, `View3D`, `Features`?**
  _High betweenness centrality (0.330) - this node is a cross-community bridge._
- **Are the 7 inferred relationships involving `get()` (e.g. with `WebGLAttributes()` and `WebGLCubeMaps()`) actually correct?**
  _`get()` has 7 INFERRED edges - model-reasoned connections that need verification._
- **What connects `Plugins`, `Configs`, `NewCfg` to the rest of the system?**
  _214 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `three.core.js` be split into smaller, more focused modules?**
  _Cohesion score 0.007751937984496124 - nodes in this community are weakly interconnected._
- **Why does `Timer` connect `LoadingManager` to `three.core.js`, `three.module.js`, `Stats`?**
  _High betweenness centrality (0.278) - this node is a cross-community bridge._
- **Should `three.module.js` be split into smaller, more focused modules?**
  _Cohesion score 0.00816326530612245 - nodes in this community are weakly interconnected._
- **Why does `initGLContext()` connect `get` to `push`, `WebGLBindingStates`, `.constructor`, `WebGLShaderCache`, `WebGLRenderer`, `WebXRManager`, `WebGLState`, `update`, `get`, `.constructor`, `portrait.js`?**
  _High betweenness centrality (0.078) - this node is a cross-community bridge._