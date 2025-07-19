import { Canvas } from '@react-three/fiber';
import { OrbitControls, useTexture } from '@react-three/drei';

function TexturedBox({ position, textures }) {
  return (
    <mesh position={position} castShadow>
      <boxGeometry args={[1, 1, 1]} />
      <meshStandardMaterial
        map={textures.color}
        normalMap={textures.normal}
        roughnessMap={textures.roughness}
        displacementMap={textures.displacement}
        displacementScale={0.05} // Ajusta la intensidad del relieve
      />
    </mesh>
  );
}

function Piramide() {
  const textures = {
    color: useTexture('PavingStones138_1K-JPG_Color.jpg'),
    normal: useTexture('PavingStones138_1K-JPG_NormalDX.jpg'),
    roughness: useTexture('PavingStones138_1K-JPG_Roughness.jpg'),
    displacement: useTexture('PavingStones138_1K-JPG_Displacement.jpg')
  };

  const niveles = 4;
  const boxes = [];

  for (let y = 0; y < niveles; y++) {
    const size = niveles - y;
    const offset = (size - 1) * 1.1 * 0.5;
    for (let i = 0; i < size; i++) {
      for (let j = 0; j < size; j++) {
        boxes.push(
          <TexturedBox
            key={`${y}-${i}-${j}`}
            position={[-offset + i * 1.1, y * 1.05, -offset + j * 1.1]}
            textures={textures}
          />
        );
      }
    }
  }
  return <>{boxes}</>;
}



export default function App() {
  return (
    <Canvas shadows camera={{ position: [5, 5, 5], fov: 50 }}>
      <ambientLight intensity={0.4} />
      <directionalLight
        position={[5, 10, 5]}
        intensity={1}
        castShadow
        shadow-mapSize-width={1024}
        shadow-mapSize-height={1024}
      />
      <Piramide />
      <OrbitControls />
    </Canvas>
  );
}
