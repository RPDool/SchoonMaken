// using System.Collections;
// using System.Collections.Generic;
// using Unity.VisualScripting;
// using UnityEngine;

// public class cleaning : MonoBehaviour
// {
//     [SerializeField] private Camera _camera;

//     [SerializeField] private Texture3D _dirtMaskBase;
//     [SerializeField] private Texture3D _brush;

//     [SerializeField] private Material _material;

//     private Texture3D _templateDirtMask;

//     private void Start()
//     {
//         CreateTexture();
//     }

//     private void Update()
//     {
//         if (Input.GetMouseButton(0)) // Corrected 'Input' capitalization
//         {
//             if (Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
//             {
//                 // Assuming the RaycastHit does not directly provide texture coordinates for a 3D texture,
//                 // and that you're trying to simulate this for a custom implementation.
//                 // This part of the code might need adjustments based on how you're actually using the texture coordinates.
//                 Vector3 textureCoord = hit.textureCoord;

//                 int pixelX = (int)(textureCoord.x * _templateDirtMask.width);
//                 int pixelY = (int)(textureCoord.y * _templateDirtMask.height);
//                 int pixelZ = (int)(textureCoord.z * _templateDirtMask.depth);

//                 for (int x = 0; x < _brush.width; x++)
//                 {
//                     for (int y = 0; y < _brush.height; y++)
//                     {
//                         for (int z = 0; z < _brush.depth; z++)
//                         {
//                             // Ensure you're not exceeding the bounds of the texture
//                             int targetX = x + pixelX;
//                             int targetY = y + pixelY;
//                             int targetZ = z + pixelZ;

//                             if (targetX >= 0 && targetX < _templateDirtMask.width && targetY >= 0 && targetY < _templateDirtMask.height && targetZ >= 0 && targetZ < _templateDirtMask.depth)
//                             {
//                                 Color pixelDirt = _brush.GetPixel(x, y, z);
//                                 Color pixelDirtMask = _templateDirtMask.GetPixel(targetX, targetY, targetZ);

//                                 _templateDirtMask.SetPixel(targetX, targetY, targetZ,
//                                 new Color(0, pixelDirtMask.g * pixelDirt.g, 0));
//                             }
//                         }
//                     }
//                     _templateDirtMask.Apply();
//                 }
//             }
//         }
//     }

//     private void CreateTexture()
//     {
//         _templateDirtMask = new Texture3D(_dirtMaskBase.width, _dirtMaskBase.height, _dirtMaskBase.depth, _dirtMaskBase.format, _dirtMaskBase.mipmapCount > 1);
//         _templateDirtMask.SetPixels(_dirtMaskBase.GetPixels());
//         _templateDirtMask.Apply();

//         _material.SetTexture("_DirtMask", _templateDirtMask);
//     }
// }
