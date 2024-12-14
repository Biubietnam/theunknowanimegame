using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001179 RID: 4473
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpBarInfo : IMessage<SpBarInfo>, IMessage, IEquatable<SpBarInfo>, IDeepCloneable<SpBarInfo>, IBufferMessage
	{
		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0600C793 RID: 51091 RVA: 0x00217878 File Offset: 0x00215A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpBarInfo> Parser
		{
			get
			{
				return SpBarInfo._parser;
			}
		}

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x0600C794 RID: 51092 RVA: 0x0021787F File Offset: 0x00215A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpBarInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0600C795 RID: 51093 RVA: 0x00217891 File Offset: 0x00215A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpBarInfo.Descriptor;
			}
		}

		// Token: 0x0600C796 RID: 51094 RVA: 0x00217898 File Offset: 0x00215A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpBarInfo()
		{
		}

		// Token: 0x0600C797 RID: 51095 RVA: 0x002178A0 File Offset: 0x00215AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpBarInfo(SpBarInfo other) : this()
		{
			this.curSp_ = other.curSp_;
			this.maxSp_ = other.maxSp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C798 RID: 51096 RVA: 0x002178D1 File Offset: 0x00215AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpBarInfo Clone()
		{
			return new SpBarInfo(this);
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0600C799 RID: 51097 RVA: 0x002178D9 File Offset: 0x00215AD9
		// (set) Token: 0x0600C79A RID: 51098 RVA: 0x002178E1 File Offset: 0x00215AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurSp
		{
			get
			{
				return this.curSp_;
			}
			set
			{
				this.curSp_ = value;
			}
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0600C79B RID: 51099 RVA: 0x002178EA File Offset: 0x00215AEA
		// (set) Token: 0x0600C79C RID: 51100 RVA: 0x002178F2 File Offset: 0x00215AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxSp
		{
			get
			{
				return this.maxSp_;
			}
			set
			{
				this.maxSp_ = value;
			}
		}

		// Token: 0x0600C79D RID: 51101 RVA: 0x002178FB File Offset: 0x00215AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpBarInfo);
		}

		// Token: 0x0600C79E RID: 51102 RVA: 0x00217909 File Offset: 0x00215B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpBarInfo other)
		{
			return other != null && (other == this || (this.CurSp == other.CurSp && this.MaxSp == other.MaxSp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C79F RID: 51103 RVA: 0x00217948 File Offset: 0x00215B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurSp != 0U)
			{
				num ^= this.CurSp.GetHashCode();
			}
			if (this.MaxSp != 0U)
			{
				num ^= this.MaxSp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C7A0 RID: 51104 RVA: 0x002179A0 File Offset: 0x00215BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C7A1 RID: 51105 RVA: 0x002179A8 File Offset: 0x00215BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7A2 RID: 51106 RVA: 0x002179B4 File Offset: 0x00215BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurSp != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CurSp);
			}
			if (this.MaxSp != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MaxSp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7A3 RID: 51107 RVA: 0x00217A0C File Offset: 0x00215C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurSp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurSp);
			}
			if (this.MaxSp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxSp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C7A4 RID: 51108 RVA: 0x00217A64 File Offset: 0x00215C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpBarInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurSp != 0U)
			{
				this.CurSp = other.CurSp;
			}
			if (other.MaxSp != 0U)
			{
				this.MaxSp = other.MaxSp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7A5 RID: 51109 RVA: 0x00217AB4 File Offset: 0x00215CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7A6 RID: 51110 RVA: 0x00217AC0 File Offset: 0x00215CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxSp = input.ReadUInt32();
					}
				}
				else
				{
					this.CurSp = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005099 RID: 20633
		private static readonly MessageParser<SpBarInfo> _parser = new MessageParser<SpBarInfo>(() => new SpBarInfo());

		// Token: 0x0400509A RID: 20634
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400509B RID: 20635
		public const int CurSpFieldNumber = 1;

		// Token: 0x0400509C RID: 20636
		private uint curSp_;

		// Token: 0x0400509D RID: 20637
		public const int MaxSpFieldNumber = 2;

		// Token: 0x0400509E RID: 20638
		private uint maxSp_;
	}
}
