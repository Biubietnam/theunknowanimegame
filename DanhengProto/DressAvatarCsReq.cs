using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003D1 RID: 977
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DressAvatarCsReq : IMessage<DressAvatarCsReq>, IMessage, IEquatable<DressAvatarCsReq>, IDeepCloneable<DressAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000792A0 File Offset: 0x000774A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DressAvatarCsReq> Parser
		{
			get
			{
				return DressAvatarCsReq._parser;
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002B80 RID: 11136 RVA: 0x000792A7 File Offset: 0x000774A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DressAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x000792B9 File Offset: 0x000774B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DressAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x000792C0 File Offset: 0x000774C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarCsReq()
		{
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x000792C8 File Offset: 0x000774C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarCsReq(DressAvatarCsReq other) : this()
		{
			this.equipmentUniqueId_ = other.equipmentUniqueId_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x000792F9 File Offset: 0x000774F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarCsReq Clone()
		{
			return new DressAvatarCsReq(this);
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x00079301 File Offset: 0x00077501
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x00079309 File Offset: 0x00077509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EquipmentUniqueId
		{
			get
			{
				return this.equipmentUniqueId_;
			}
			set
			{
				this.equipmentUniqueId_ = value;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x00079312 File Offset: 0x00077512
		// (set) Token: 0x06002B88 RID: 11144 RVA: 0x0007931A File Offset: 0x0007751A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x00079323 File Offset: 0x00077523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DressAvatarCsReq);
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x00079331 File Offset: 0x00077531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DressAvatarCsReq other)
		{
			return other != null && (other == this || (this.EquipmentUniqueId == other.EquipmentUniqueId && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00079370 File Offset: 0x00077570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EquipmentUniqueId != 0U)
			{
				num ^= this.EquipmentUniqueId.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x000793C8 File Offset: 0x000775C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x000793D0 File Offset: 0x000775D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x000793DC File Offset: 0x000775DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.EquipmentUniqueId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EquipmentUniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x00079438 File Offset: 0x00077638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EquipmentUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EquipmentUniqueId);
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x00079490 File Offset: 0x00077690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DressAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EquipmentUniqueId != 0U)
			{
				this.EquipmentUniqueId = other.EquipmentUniqueId;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x000794E0 File Offset: 0x000776E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x000794EC File Offset: 0x000776EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EquipmentUniqueId = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040011A5 RID: 4517
		private static readonly MessageParser<DressAvatarCsReq> _parser = new MessageParser<DressAvatarCsReq>(() => new DressAvatarCsReq());

		// Token: 0x040011A6 RID: 4518
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011A7 RID: 4519
		public const int EquipmentUniqueIdFieldNumber = 14;

		// Token: 0x040011A8 RID: 4520
		private uint equipmentUniqueId_;

		// Token: 0x040011A9 RID: 4521
		public const int AvatarIdFieldNumber = 12;

		// Token: 0x040011AA RID: 4522
		private uint avatarId_;
	}
}
