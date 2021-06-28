/*{
  "CATEGORIES": [
      "Testing"
  ],
  "CREDIT": "NERDDISCO",
  "INPUTS": [
      {
          "NAME": "inputImage",
          "TYPE": "image"
      }
  ],
  "ISFVSN": "2"
}
*/

void main() {
  float x = gl_FragCoord.x;
  float y = gl_FragCoord.y;
  vec4 color = IMG_PIXEL(inputImage, gl_FragCoord.xy);
  color = IMG_PIXEL(inputImage, vec2(gl_FragCoord.xy));
  color = IMG_PIXEL(inputImage, vec2(gl_FragCoord.x, gl_FragCoord.y));
  color = IMG_PIXEL(inputImage, vec2(x, y));
  color = IMG_PIXEL(inputImage, vec3(x, y, x).xy);
  color = IMG_PIXEL(inputImage, vec4(x, y, x, y).xy);
  color = vec4(color.rgb, IMG_PIXEL(inputImage, gl_FragCoord.xy).a);
  color = vec4(color.r, color.g, IMG_PIXEL(inputImage, gl_FragCoord.xy).b, color.a);
  color = vec4(color.r, color.g, IMG_PIXEL(inputImage, vec4(x, y, x, y).xy).b, color.a);
  color = vec4(IMG_PIXEL(inputImage, gl_FragCoord.xy).r, IMG_PIXEL(inputImage, gl_FragCoord.xy).g, IMG_PIXEL(inputImage, gl_FragCoord.xy).b, color.a);

  gl_FragColor = color;
}