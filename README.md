# UnityURP-NewEdgeDirectedInterpolation
Implementation of the NEDI (New Edge-Directed Interpolation) from Xin Li & Michael Orchard [Paper](https://ieeexplore.ieee.org/document/951537)</br>
Special thanks for Parashar Krishnamachari for his [Post](https://chiranjivi.tripod.com/EDITut.html) which helped me a lot to understand the algorithm.</br>

I tried to optimize the computation as much as possible to experiment with the possibility of implementing NEDI in realtime.</br>
The project contrains multiple examples of the implementation, you can use your own images just make sure, after importing them, to disable the compression Unity applies by default.</br>

## Comparaison Bilinear vs NEDI (x4 upscale in each axis)
<img width="1920" height="1080" alt="Image Sequence_007_0005" src="https://github.com/user-attachments/assets/76363c43-ca99-4952-89c2-2ce4e869ffb8" />
<img width="1920" height="1080" alt="Image Sequence_003_0005" src="https://github.com/user-attachments/assets/272c1d7e-05e7-4996-9f05-db2700d9410c" />
<img width="1920" height="1080" alt="Image Sequence_004_0005" src="https://github.com/user-attachments/assets/a0f227c7-4909-48d4-80a4-02bc8e60eb9f" />
<img width="1920" height="768" alt="Image Sequence_005_0005" src="https://github.com/user-attachments/assets/80818b43-bfc0-4bc3-88e1-39dfcdbc33d3" />
<img width="1920" height="768" alt="Image Sequence_006_0005" src="https://github.com/user-attachments/assets/b7609243-8a0e-4383-852a-3a606d4d165f" />
<img width="1920" height="1080" alt="Image Sequence_008_0005" src="https://github.com/user-attachments/assets/9675a640-912e-415e-af5a-db9b3a50b4f4" />
<img width="1920" height="1080" alt="Image Sequence_010_0005" src="https://github.com/user-attachments/assets/9b238394-2790-4ee0-910f-597e5c2ad6ae" />
<img width="1920" height="768" alt="Image Sequence_009_0005" src="https://github.com/user-attachments/assets/c26eca9b-38bc-4a0c-961a-665c32a91f79" />
<img width="1920" height="1080" alt="Image Sequence_001_0049" src="https://github.com/user-attachments/assets/e96e86d8-e3b5-48f2-836a-8dbc6e0da06c" />
<img width="1154" height="462" alt="Image Sequence_001_0049" src="https://github.com/user-attachments/assets/3dd85bdc-8775-4d97-9cda-a921c6ec5be5" />

## References
- [NEDI Paper](https://ieeexplore.ieee.org/document/951537)
- [Parashar Krishnamachari Post](https://chiranjivi.tripod.com/EDITut.html)
- [Python Implementation](https://github.com/Kirstihly/Edge-Directed_Interpolation) by Kirstihly
