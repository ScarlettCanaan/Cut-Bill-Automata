clear all; close all; clc;
Source = imread('C:\Users\Canaan\Documents\GitHub\embeding\demo_C#\demoCSharp_Hough\\rectangle.png');
GrySource = rgb2gray(Source);   %RGB转灰度图
Sobel_Source = edge(GrySource,'canny');%边缘检测
[m,n] = size(Sobel_Source);     %获取图像大小
%Hough变换
rou = round(sqrt(m^2+n^2));     %获取hough的rou的大小
theta = 180;                    %获取houghtheta
r = zeros(rou,theta);           %初始化hough坐标系
for i = 1:m
    for j = 1:n
        if Sobel_Source(i,j) == 1
            for k = 1:theta
                ru = round(abs(i*cos(k*3.14/180)+j*sin(k*3.14/180)));
                r(ru+1,k) = r(ru+1,k)+1;
            end
        end
    end
end
r_max = r(1,1);
c = 0;
for i = 1:rou
    for j = 1:theta
        if r(i,j) > r_max
            r_max = r(i,j);
            rou_max = i;
            c = j;
        end
    end
end

if c <= 90
    rot_theta = -c;
else
    rot_theta = 180-c;
end
Img = imrotate(Sobel_Source,rot_theta,'crop');%旋转图像

r2 = zeros(rou,theta);           %初始化hough坐标系
for i = 1:m
    for j = 1:n
        if Img(i,j) == 1
            for k = 1:theta
                ru2 = round(abs(i*cos(k*3.14/180)+j*sin(k*3.14/180)));
                r2(ru2+1,k) = r2(ru2+1,k)+1;
            end
        end
    end
end
r_max2 = r2(1,90);
r_max3 = r2(1,1);
for i = 1:rou
    if r2(i,90) > r_max2
        r_max2 = r2(i,90);
        rou_max2 = i;
    end
    if r2(i,1) > r_max3
        r_max3 = r2(i,1);
        rou_max3 = i;
    end
end
rCounter = rou;
flag = 1;
flag2 = 1;
for i = 1:rou
    temp = abs(r2(rCounter,90) - r_max2);
    if temp < 6 & rCounter ~= rou_max2 & flag == 1
        rou_max22 = rCounter;
        flag = 0;
    end
    if abs(r2(i,1) - r_max3) < 3 & i ~= rou_max3 & flag2 == 1
        rou_max32 = i;
        flag2 = 0;
    end
    rCounter = rCounter - 1;
end

result = imrotate(Source,rot_theta,'crop');%旋转图像
result = imcrop(result, [rou_max2,rou_max32,rou_max22-rou_max2-1,rou_max3-rou_max32-1]);

figure;
subplot(221); imshow(Source);title('原图');
subplot(222); imshow(Sobel_Source);title('边缘提取')
subplot(223); imshow(Img);title('hough倾斜校正');
subplot(224); imshow(result);title('图像裁剪');

% % 测试霍夫变换
% clc
% clear
% close all
%  
% % 读取图像
% I  = imread('C:\Users\Canaan\Documents\GitHub\embeding\demo_C#\demoCSharp_Hough\\testInput.jpg');
% %rotI = imrotate(I,80,'crop'); % 旋转33度，保持原图片大小
% rotI = rgb2gray(I);
% fig1 = imshow(rotI);
%  
% % 提取边
% BW = edge(rotI,'sobel','horizontal');
% figure, imshow(BW);
%  
% % 霍夫变换
% [H,theta,rho] = hough(BW); % 计算二值图像的标准霍夫变换，H为霍夫变换矩阵，theta,rho为计算霍夫变换的角度和半径值
% figure, imshow(imadjust(mat2gray(H)),[],'XData',theta,'YData',rho,...
%     'InitialMagnification','fit');
% xlabel('\theta (degrees)'), ylabel('\rho');
% axis on, axis normal, hold on;
% colormap(hot)
%  
% % 显示霍夫变换矩阵中的极值点
% P = houghpeaks(H,50,'threshold',ceil(0.3*max(H(:)))); % 从霍夫变换矩阵H中提取5个极值点
% x = theta(P(:,2));
% y = rho(P(:,1));
% plot(x,y,'s','color','black');
%  
% % 找原图中的线
% lines = houghlines(BW,theta,rho,P,'FillGap',18,'MinLength',180);
% figure, imshow(rotI), hold on
% max_len = 0;
% for k = 1:length(lines)
%     % 绘制各条线
%     xy = [lines(k).point1; lines(k).point2];
%     plot(xy(:,1),xy(:,2),'LineWidth',2,'Color','green');
%    
%     % 绘制线的起点（黄色）、终点（红色）
%     plot(xy(1,1),xy(1,2),'x','LineWidth',2,'Color','yellow');
%     plot(xy(2,1),xy(2,2),'x','LineWidth',2,'Color','red');
%    
%     % 计算线的长度，找最长线段
%     len = norm(lines(k).point1 - lines(k).point2);
%     if ( len > max_len)
%         max_len = len;
%         xy_long = xy;
%     end
% end
%  
% % 以红色线高亮显示最长的线
% plot(xy_long(:,1),xy_long(:,2),'LineWidth',2,'Color','red');
