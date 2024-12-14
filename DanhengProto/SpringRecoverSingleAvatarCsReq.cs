using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001181 RID: 4481
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpringRecoverSingleAvatarCsReq : IMessage<SpringRecoverSingleAvatarCsReq>, IMessage, IEquatable<SpringRecoverSingleAvatarCsReq>, IDeepCloneable<SpringRecoverSingleAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x0600C7F2 RID: 51186 RVA: 0x00218797 File Offset: 0x00216997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpringRecoverSingleAvatarCsReq> Parser
		{
			get
			{
				return SpringRecoverSingleAvatarCsReq._parser;
			}
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x0600C7F3 RID: 51187 RVA: 0x0021879E File Offset: 0x0021699E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpringRecoverSingleAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x0600C7F4 RID: 51188 RVA: 0x002187B0 File Offset: 0x002169B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringRecoverSingleAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x0600C7F5 RID: 51189 RVA: 0x002187B7 File Offset: 0x002169B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverSingleAvatarCsReq()
		{
		}

		// Token: 0x0600C7F6 RID: 51190 RVA: 0x002187C0 File Offset: 0x002169C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverSingleAvatarCsReq(SpringRecoverSingleAvatarCsReq other) : this()
		{
			this.floorId_ = other.floorId_;
			this.hKCBJJGKNFO_ = other.hKCBJJGKNFO_;
			this.planeId_ = other.planeId_;
			this.id_ = other.id_;
			this.avatarType_ = other.avatarType_;
			this.propEntityId_ = other.propEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7F7 RID: 51191 RVA: 0x0021882C File Offset: 0x00216A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverSingleAvatarCsReq Clone()
		{
			return new SpringRecoverSingleAvatarCsReq(this);
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0600C7F8 RID: 51192 RVA: 0x00218834 File Offset: 0x00216A34
		// (set) Token: 0x0600C7F9 RID: 51193 RVA: 0x0021883C File Offset: 0x00216A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FloorId
		{
			get
			{
				return this.floorId_;
			}
			set
			{
				this.floorId_ = value;
			}
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0600C7FA RID: 51194 RVA: 0x00218845 File Offset: 0x00216A45
		// (set) Token: 0x0600C7FB RID: 51195 RVA: 0x0021884D File Offset: 0x00216A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HKCBJJGKNFO
		{
			get
			{
				return this.hKCBJJGKNFO_;
			}
			set
			{
				this.hKCBJJGKNFO_ = value;
			}
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0600C7FC RID: 51196 RVA: 0x00218856 File Offset: 0x00216A56
		// (set) Token: 0x0600C7FD RID: 51197 RVA: 0x0021885E File Offset: 0x00216A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlaneId
		{
			get
			{
				return this.planeId_;
			}
			set
			{
				this.planeId_ = value;
			}
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x0600C7FE RID: 51198 RVA: 0x00218867 File Offset: 0x00216A67
		// (set) Token: 0x0600C7FF RID: 51199 RVA: 0x0021886F File Offset: 0x00216A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0600C800 RID: 51200 RVA: 0x00218878 File Offset: 0x00216A78
		// (set) Token: 0x0600C801 RID: 51201 RVA: 0x00218880 File Offset: 0x00216A80
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

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0600C802 RID: 51202 RVA: 0x00218889 File Offset: 0x00216A89
		// (set) Token: 0x0600C803 RID: 51203 RVA: 0x00218891 File Offset: 0x00216A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropEntityId
		{
			get
			{
				return this.propEntityId_;
			}
			set
			{
				this.propEntityId_ = value;
			}
		}

		// Token: 0x0600C804 RID: 51204 RVA: 0x0021889A File Offset: 0x00216A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringRecoverSingleAvatarCsReq);
		}

		// Token: 0x0600C805 RID: 51205 RVA: 0x002188A8 File Offset: 0x00216AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringRecoverSingleAvatarCsReq other)
		{
			return other != null && (other == this || (this.FloorId == other.FloorId && this.HKCBJJGKNFO == other.HKCBJJGKNFO && this.PlaneId == other.PlaneId && this.Id == other.Id && this.AvatarType == other.AvatarType && this.PropEntityId == other.PropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C806 RID: 51206 RVA: 0x00218934 File Offset: 0x00216B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FloorId != 0U)
			{
				num ^= this.FloorId.GetHashCode();
			}
			if (this.HKCBJJGKNFO)
			{
				num ^= this.HKCBJJGKNFO.GetHashCode();
			}
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C807 RID: 51207 RVA: 0x002189F6 File Offset: 0x00216BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C808 RID: 51208 RVA: 0x002189FE File Offset: 0x00216BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C809 RID: 51209 RVA: 0x00218A08 File Offset: 0x00216C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FloorId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FloorId);
			}
			if (this.HKCBJJGKNFO)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.HKCBJJGKNFO);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.PlaneId);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Id);
			}
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C80A RID: 51210 RVA: 0x00218AD4 File Offset: 0x00216CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FloorId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FloorId);
			}
			if (this.HKCBJJGKNFO)
			{
				num += 2;
			}
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C80B RID: 51211 RVA: 0x00218B80 File Offset: 0x00216D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringRecoverSingleAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FloorId != 0U)
			{
				this.FloorId = other.FloorId;
			}
			if (other.HKCBJJGKNFO)
			{
				this.HKCBJJGKNFO = other.HKCBJJGKNFO;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C80C RID: 51212 RVA: 0x00218C20 File Offset: 0x00216E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C80D RID: 51213 RVA: 0x00218C2C File Offset: 0x00216E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.FloorId = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.HKCBJJGKNFO = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.AvatarType = (AvatarType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.PlaneId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.PropEntityId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040050BA RID: 20666
		private static readonly MessageParser<SpringRecoverSingleAvatarCsReq> _parser = new MessageParser<SpringRecoverSingleAvatarCsReq>(() => new SpringRecoverSingleAvatarCsReq());

		// Token: 0x040050BB RID: 20667
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050BC RID: 20668
		public const int FloorIdFieldNumber = 2;

		// Token: 0x040050BD RID: 20669
		private uint floorId_;

		// Token: 0x040050BE RID: 20670
		public const int HKCBJJGKNFOFieldNumber = 3;

		// Token: 0x040050BF RID: 20671
		private bool hKCBJJGKNFO_;

		// Token: 0x040050C0 RID: 20672
		public const int PlaneIdFieldNumber = 12;

		// Token: 0x040050C1 RID: 20673
		private uint planeId_;

		// Token: 0x040050C2 RID: 20674
		public const int IdFieldNumber = 13;

		// Token: 0x040050C3 RID: 20675
		private uint id_;

		// Token: 0x040050C4 RID: 20676
		public const int AvatarTypeFieldNumber = 8;

		// Token: 0x040050C5 RID: 20677
		private AvatarType avatarType_;

		// Token: 0x040050C6 RID: 20678
		public const int PropEntityIdFieldNumber = 14;

		// Token: 0x040050C7 RID: 20679
		private uint propEntityId_;
	}
}
