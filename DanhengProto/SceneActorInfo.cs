using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200104D RID: 4173
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneActorInfo : IMessage<SceneActorInfo>, IMessage, IEquatable<SceneActorInfo>, IDeepCloneable<SceneActorInfo>, IBufferMessage
	{
		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0600B9A2 RID: 47522 RVA: 0x001F240F File Offset: 0x001F060F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneActorInfo> Parser
		{
			get
			{
				return SceneActorInfo._parser;
			}
		}

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x0600B9A3 RID: 47523 RVA: 0x001F2416 File Offset: 0x001F0616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneActorInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0600B9A4 RID: 47524 RVA: 0x001F2428 File Offset: 0x001F0628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneActorInfo.Descriptor;
			}
		}

		// Token: 0x0600B9A5 RID: 47525 RVA: 0x001F242F File Offset: 0x001F062F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneActorInfo()
		{
		}

		// Token: 0x0600B9A6 RID: 47526 RVA: 0x001F2438 File Offset: 0x001F0638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneActorInfo(SceneActorInfo other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.baseAvatarId_ = other.baseAvatarId_;
			this.mapLayer_ = other.mapLayer_;
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B9A7 RID: 47527 RVA: 0x001F248C File Offset: 0x001F068C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneActorInfo Clone()
		{
			return new SceneActorInfo(this);
		}

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0600B9A8 RID: 47528 RVA: 0x001F2494 File Offset: 0x001F0694
		// (set) Token: 0x0600B9A9 RID: 47529 RVA: 0x001F249C File Offset: 0x001F069C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x0600B9AA RID: 47530 RVA: 0x001F24A5 File Offset: 0x001F06A5
		// (set) Token: 0x0600B9AB RID: 47531 RVA: 0x001F24AD File Offset: 0x001F06AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BaseAvatarId
		{
			get
			{
				return this.baseAvatarId_;
			}
			set
			{
				this.baseAvatarId_ = value;
			}
		}

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x0600B9AC RID: 47532 RVA: 0x001F24B6 File Offset: 0x001F06B6
		// (set) Token: 0x0600B9AD RID: 47533 RVA: 0x001F24BE File Offset: 0x001F06BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapLayer
		{
			get
			{
				return this.mapLayer_;
			}
			set
			{
				this.mapLayer_ = value;
			}
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0600B9AE RID: 47534 RVA: 0x001F24C7 File Offset: 0x001F06C7
		// (set) Token: 0x0600B9AF RID: 47535 RVA: 0x001F24CF File Offset: 0x001F06CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x0600B9B0 RID: 47536 RVA: 0x001F24D8 File Offset: 0x001F06D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneActorInfo);
		}

		// Token: 0x0600B9B1 RID: 47537 RVA: 0x001F24E8 File Offset: 0x001F06E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneActorInfo other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.BaseAvatarId == other.BaseAvatarId && this.MapLayer == other.MapLayer && this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9B2 RID: 47538 RVA: 0x001F2554 File Offset: 0x001F0754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this.MapLayer != 0U)
			{
				num ^= this.MapLayer.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B9B3 RID: 47539 RVA: 0x001F25E4 File Offset: 0x001F07E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x001F25EC File Offset: 0x001F07EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9B5 RID: 47541 RVA: 0x001F25F8 File Offset: 0x001F07F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MapLayer != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MapLayer);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Uid);
			}
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B9B6 RID: 47542 RVA: 0x001F268C File Offset: 0x001F088C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this.MapLayer != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapLayer);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B9B7 RID: 47543 RVA: 0x001F2714 File Offset: 0x001F0914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneActorInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			if (other.MapLayer != 0U)
			{
				this.MapLayer = other.MapLayer;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B9B8 RID: 47544 RVA: 0x001F278C File Offset: 0x001F098C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B9B9 RID: 47545 RVA: 0x001F2798 File Offset: 0x001F0998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 48U)
					{
						this.MapLayer = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Uid = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.BaseAvatarId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.AvatarType = (AvatarType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004B29 RID: 19241
		private static readonly MessageParser<SceneActorInfo> _parser = new MessageParser<SceneActorInfo>(() => new SceneActorInfo());

		// Token: 0x04004B2A RID: 19242
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B2B RID: 19243
		public const int AvatarTypeFieldNumber = 13;

		// Token: 0x04004B2C RID: 19244
		private AvatarType avatarType_;

		// Token: 0x04004B2D RID: 19245
		public const int BaseAvatarIdFieldNumber = 10;

		// Token: 0x04004B2E RID: 19246
		private uint baseAvatarId_;

		// Token: 0x04004B2F RID: 19247
		public const int MapLayerFieldNumber = 6;

		// Token: 0x04004B30 RID: 19248
		private uint mapLayer_;

		// Token: 0x04004B31 RID: 19249
		public const int UidFieldNumber = 9;

		// Token: 0x04004B32 RID: 19250
		private uint uid_;
	}
}
