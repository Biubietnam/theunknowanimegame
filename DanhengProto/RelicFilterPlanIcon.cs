using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DA7 RID: 3495
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RelicFilterPlanIcon : IMessage<RelicFilterPlanIcon>, IMessage, IEquatable<RelicFilterPlanIcon>, IDeepCloneable<RelicFilterPlanIcon>, IBufferMessage
	{
		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x06009C34 RID: 39988 RVA: 0x0019FD44 File Offset: 0x0019DF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RelicFilterPlanIcon> Parser
		{
			get
			{
				return RelicFilterPlanIcon._parser;
			}
		}

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x06009C35 RID: 39989 RVA: 0x0019FD4B File Offset: 0x0019DF4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RelicFilterPlanIconReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x06009C36 RID: 39990 RVA: 0x0019FD5D File Offset: 0x0019DF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelicFilterPlanIcon.Descriptor;
			}
		}

		// Token: 0x06009C37 RID: 39991 RVA: 0x0019FD64 File Offset: 0x0019DF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanIcon()
		{
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x0019FD6C File Offset: 0x0019DF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanIcon(RelicFilterPlanIcon other) : this()
		{
			this.isAvatarIcon_ = other.isAvatarIcon_;
			this.iconId_ = other.iconId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x0019FD9D File Offset: 0x0019DF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanIcon Clone()
		{
			return new RelicFilterPlanIcon(this);
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x06009C3A RID: 39994 RVA: 0x0019FDA5 File Offset: 0x0019DFA5
		// (set) Token: 0x06009C3B RID: 39995 RVA: 0x0019FDAD File Offset: 0x0019DFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAvatarIcon
		{
			get
			{
				return this.isAvatarIcon_;
			}
			set
			{
				this.isAvatarIcon_ = value;
			}
		}

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x06009C3C RID: 39996 RVA: 0x0019FDB6 File Offset: 0x0019DFB6
		// (set) Token: 0x06009C3D RID: 39997 RVA: 0x0019FDBE File Offset: 0x0019DFBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IconId
		{
			get
			{
				return this.iconId_;
			}
			set
			{
				this.iconId_ = value;
			}
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x0019FDC7 File Offset: 0x0019DFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelicFilterPlanIcon);
		}

		// Token: 0x06009C3F RID: 39999 RVA: 0x0019FDD5 File Offset: 0x0019DFD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelicFilterPlanIcon other)
		{
			return other != null && (other == this || (this.IsAvatarIcon == other.IsAvatarIcon && this.IconId == other.IconId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x0019FE14 File Offset: 0x0019E014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsAvatarIcon)
			{
				num ^= this.IsAvatarIcon.GetHashCode();
			}
			if (this.IconId != 0U)
			{
				num ^= this.IconId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C41 RID: 40001 RVA: 0x0019FE6C File Offset: 0x0019E06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009C42 RID: 40002 RVA: 0x0019FE74 File Offset: 0x0019E074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C43 RID: 40003 RVA: 0x0019FE80 File Offset: 0x0019E080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IconId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.IconId);
			}
			if (this.IsAvatarIcon)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsAvatarIcon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x0019FEDC File Offset: 0x0019E0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsAvatarIcon)
			{
				num += 2;
			}
			if (this.IconId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IconId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C45 RID: 40005 RVA: 0x0019FF28 File Offset: 0x0019E128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelicFilterPlanIcon other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsAvatarIcon)
			{
				this.IsAvatarIcon = other.IsAvatarIcon;
			}
			if (other.IconId != 0U)
			{
				this.IconId = other.IconId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C46 RID: 40006 RVA: 0x0019FF78 File Offset: 0x0019E178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x0019FF84 File Offset: 0x0019E184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsAvatarIcon = input.ReadBool();
					}
				}
				else
				{
					this.IconId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003CA4 RID: 15524
		private static readonly MessageParser<RelicFilterPlanIcon> _parser = new MessageParser<RelicFilterPlanIcon>(() => new RelicFilterPlanIcon());

		// Token: 0x04003CA5 RID: 15525
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CA6 RID: 15526
		public const int IsAvatarIconFieldNumber = 11;

		// Token: 0x04003CA7 RID: 15527
		private bool isAvatarIcon_;

		// Token: 0x04003CA8 RID: 15528
		public const int IconIdFieldNumber = 4;

		// Token: 0x04003CA9 RID: 15529
		private uint iconId_;
	}
}
