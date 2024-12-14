using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000487 RID: 1159
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EntityBuffChangeInfo : IMessage<EntityBuffChangeInfo>, IMessage, IEquatable<EntityBuffChangeInfo>, IDeepCloneable<EntityBuffChangeInfo>, IBufferMessage
	{
		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x0600339D RID: 13213 RVA: 0x0008DC37 File Offset: 0x0008BE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityBuffChangeInfo> Parser
		{
			get
			{
				return EntityBuffChangeInfo._parser;
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x0600339E RID: 13214 RVA: 0x0008DC3E File Offset: 0x0008BE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EntityBuffChangeInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x0600339F RID: 13215 RVA: 0x0008DC50 File Offset: 0x0008BE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBuffChangeInfo.Descriptor;
			}
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x0008DC57 File Offset: 0x0008BE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffChangeInfo()
		{
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x0008DC60 File Offset: 0x0008BE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffChangeInfo(EntityBuffChangeInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.buffChangeInfo_ = ((other.buffChangeInfo_ != null) ? other.buffChangeInfo_.Clone() : null);
			this.removeBuffId_ = other.removeBuffId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x0008DCC4 File Offset: 0x0008BEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffChangeInfo Clone()
		{
			return new EntityBuffChangeInfo(this);
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x060033A3 RID: 13219 RVA: 0x0008DCCC File Offset: 0x0008BECC
		// (set) Token: 0x060033A4 RID: 13220 RVA: 0x0008DCD4 File Offset: 0x0008BED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x0008DCDD File Offset: 0x0008BEDD
		// (set) Token: 0x060033A6 RID: 13222 RVA: 0x0008DCE5 File Offset: 0x0008BEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffInfo BuffChangeInfo
		{
			get
			{
				return this.buffChangeInfo_;
			}
			set
			{
				this.buffChangeInfo_ = value;
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x060033A7 RID: 13223 RVA: 0x0008DCEE File Offset: 0x0008BEEE
		// (set) Token: 0x060033A8 RID: 13224 RVA: 0x0008DCF6 File Offset: 0x0008BEF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RemoveBuffId
		{
			get
			{
				return this.removeBuffId_;
			}
			set
			{
				this.removeBuffId_ = value;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x0008DCFF File Offset: 0x0008BEFF
		// (set) Token: 0x060033AA RID: 13226 RVA: 0x0008DD07 File Offset: 0x0008BF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityBuffChangeType Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x0008DD10 File Offset: 0x0008BF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBuffChangeInfo);
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x0008DD20 File Offset: 0x0008BF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBuffChangeInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.BuffChangeInfo, other.BuffChangeInfo) && this.RemoveBuffId == other.RemoveBuffId && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x0008DD90 File Offset: 0x0008BF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.buffChangeInfo_ != null)
			{
				num ^= this.BuffChangeInfo.GetHashCode();
			}
			if (this.RemoveBuffId != 0U)
			{
				num ^= this.RemoveBuffId.GetHashCode();
			}
			if (this.Reason != SceneEntityBuffChangeType.Default)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x0008DE1D File Offset: 0x0008C01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x0008DE25 File Offset: 0x0008C025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x0008DE30 File Offset: 0x0008C030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.buffChangeInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.BuffChangeInfo);
			}
			if (this.RemoveBuffId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.RemoveBuffId);
			}
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.EntityId);
			}
			if (this.Reason != SceneEntityBuffChangeType.Default)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x0008DEC4 File Offset: 0x0008C0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
			}
			if (this.buffChangeInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffChangeInfo);
			}
			if (this.RemoveBuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RemoveBuffId);
			}
			if (this.Reason != SceneEntityBuffChangeType.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x0008DF4C File Offset: 0x0008C14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBuffChangeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			if (other.buffChangeInfo_ != null)
			{
				if (this.buffChangeInfo_ == null)
				{
					this.BuffChangeInfo = new BuffInfo();
				}
				this.BuffChangeInfo.MergeFrom(other.BuffChangeInfo);
			}
			if (other.RemoveBuffId != 0U)
			{
				this.RemoveBuffId = other.RemoveBuffId;
			}
			if (other.Reason != SceneEntityBuffChangeType.Default)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x0008DFDC File Offset: 0x0008C1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x0008DFE8 File Offset: 0x0008C1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 50U)
					{
						if (this.buffChangeInfo_ == null)
						{
							this.BuffChangeInfo = new BuffInfo();
						}
						input.ReadMessage(this.BuffChangeInfo);
						continue;
					}
					if (num == 56U)
					{
						this.RemoveBuffId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.EntityId = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Reason = (SceneEntityBuffChangeType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400147D RID: 5245
		private static readonly MessageParser<EntityBuffChangeInfo> _parser = new MessageParser<EntityBuffChangeInfo>(() => new EntityBuffChangeInfo());

		// Token: 0x0400147E RID: 5246
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400147F RID: 5247
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04001480 RID: 5248
		private uint entityId_;

		// Token: 0x04001481 RID: 5249
		public const int BuffChangeInfoFieldNumber = 6;

		// Token: 0x04001482 RID: 5250
		private BuffInfo buffChangeInfo_;

		// Token: 0x04001483 RID: 5251
		public const int RemoveBuffIdFieldNumber = 7;

		// Token: 0x04001484 RID: 5252
		private uint removeBuffId_;

		// Token: 0x04001485 RID: 5253
		public const int ReasonFieldNumber = 11;

		// Token: 0x04001486 RID: 5254
		private SceneEntityBuffChangeType reason_;
	}
}
