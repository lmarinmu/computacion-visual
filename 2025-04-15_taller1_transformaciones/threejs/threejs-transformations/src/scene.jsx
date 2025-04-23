export default function Scene() {
  const mesh = useRef()

  useFrame(({ clock }) => {
    const t = clock.getElapsedTime()

    mesh.current.position.x = Math.cos(t) * 4
    mesh.current.position.z = Math.sin(t) * 4
    mesh.current.rotation.y = t
  })

  return (
    <>
      {/* The orbiting tetrahedron */}
      <mesh ref={mesh}>
        <tetrahedronGeometry args={[1, 0]} />
        <meshStandardMaterial color="#8AC" />
      </mesh>

      {/* Center point marker (static red sphere at the origin) */}
      <mesh position={[0, 0, 0]}>
        <sphereGeometry args={[0.1, 16, 16]} />
        <meshBasicMaterial color="red" />
      </mesh>
    </>
  )
}
import { useRef } from 'react'    
import { useFrame } from '@react-three/fiber'