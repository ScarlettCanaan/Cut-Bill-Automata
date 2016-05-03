% clear all; close all; clc;
% Source = imread('C:\Users\Canaan\Documents\GitHub\embeding\demo_C#\demoCSharp_Hough\\testInput.jpg');
% GrySource = rgb2gray(Source);   %转成灰度图像
% Sobel_Source = edge(GrySource,'sobel','horizontal');%边缘检测
% [m,n] = size(Sobel_Source);     %获取图像大小
% %Hough变换
% rou = round(sqrt(m^2+n^2));     %获取rou最大值
% theta = 180;                    %获取theta角度最大值
% r = zeros(rou,theta);           %产生初值为0的计数矩阵
% for i = 1:m
%     for j = 1:n
%         if GrySource(i,j) == 1
%             for k = 1:theta
%                 ru = round(abs(i*cos(k*3.14/180)+j*sin(k*3.14/180)));
%                 r(ru+1,k) = r(ru+1,k)+1
%             end
%         end
%     end
% end
% r_max = r(1,1);
% for i = 1:rou
%     for j = 1:theta
%         if r(i,j) > r_max
%             r_max = r(i,j);     %找出矩阵最大值（最长直线）
%             rou_max = i;
%             c = j;
%         end
%     end
% end
% for i = 1:rou
% 	if r(i,c) == r(rou_max,c) & i ~= rou_max
% 		temp = i;
% 	end
% end

% if c <= 90
%     rot_theta = -c;
% else
%     rot_theta = 180-c;
% end
% Img = imrotate(Sobel_Source,rot_theta,'crop');%旋转矫正
% figure;
% subplot(131); imshow(Source);
% subplot(132); imshow(Sobel_Source);
% subplot(133); imshow(Img);

% 测试霍夫变换
clc
clear
close all
 
% 读取图像
I  = imread('C:\Users\Canaan\Documents\GitHub\embeding\demo_C#\demoCSharp_Hough\\testInput.jpg');
%rotI = imrotate(I,80,'crop'); % 旋转33度，保持原图片大小
rotI = rgb2gray(I);
fig1 = imshow(rotI);
 
% 提取边
BW = edge(rotI,'sobel','horizontal');
figure, imshow(BW);
 
% 霍夫变换
[H,theta,rho] = hough(BW); % 计算二值图像的标准霍夫变换，H为霍夫变换矩阵，theta,rho为计算霍夫变换的角度和半径值
figure, imshow(imadjust(mat2gray(H)),[],'XData',theta,'YData',rho,...
    'InitialMagnification','fit');
xlabel('\theta (degrees)'), ylabel('\rho');
axis on, axis normal, hold on;
colormap(hot)
 
% 显示霍夫变换矩阵中的极值点
P = houghpeaks(H,50,'threshold',ceil(0.3*max(H(:)))); % 从霍夫变换矩阵H中提取5个极值点
x = theta(P(:,2));
y = rho(P(:,1));
plot(x,y,'s','color','black');
 
% 找原图中的线
lines = houghlines(BW,theta,rho,P,'FillGap',18,'MinLength',180);
figure, imshow(rotI), hold on
max_len = 0;
for k = 1:length(lines)
    % 绘制各条线
    xy = [lines(k).point1; lines(k).point2];
    plot(xy(:,1),xy(:,2),'LineWidth',2,'Color','green');
   
    % 绘制线的起点（黄色）、终点（红色）
    plot(xy(1,1),xy(1,2),'x','LineWidth',2,'Color','yellow');
    plot(xy(2,1),xy(2,2),'x','LineWidth',2,'Color','red');
   
    % 计算线的长度，找最长线段
    len = norm(lines(k).point1 - lines(k).point2);
    if ( len > max_len)
        max_len = len;
        xy_long = xy;
    end
end
 
% 以红色线高亮显示最长的线
plot(xy_long(:,1),xy_long(:,2),'LineWidth',2,'Color','red');
