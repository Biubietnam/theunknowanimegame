using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B55 RID: 2901
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGuessChooseCsReq : IMessage<MonopolyGuessChooseCsReq>, IMessage, IEquatable<MonopolyGuessChooseCsReq>, IDeepCloneable<MonopolyGuessChooseCsReq>, IBufferMessage
	{
		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x06008064 RID: 32868 RVA: 0x00152C04 File Offset: 0x00150E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGuessChooseCsReq> Parser
		{
			get
			{
				return MonopolyGuessChooseCsReq._parser;
			}
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x06008065 RID: 32869 RVA: 0x00152C0B File Offset: 0x00150E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGuessChooseCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x06008066 RID: 32870 RVA: 0x00152C1D File Offset: 0x00150E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGuessChooseCsReq.Descriptor;
			}
		}

		// Token: 0x06008067 RID: 32871 RVA: 0x00152C24 File Offset: 0x00150E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessChooseCsReq()
		{
		}

		// Token: 0x06008068 RID: 32872 RVA: 0x00152C2C File Offset: 0x00150E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessChooseCsReq(MonopolyGuessChooseCsReq other) : this()
		{
			this.mGOCICCJGFE_ = other.mGOCICCJGFE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x00152C51 File Offset: 0x00150E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessChooseCsReq Clone()
		{
			return new MonopolyGuessChooseCsReq(this);
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x0600806A RID: 32874 RVA: 0x00152C59 File Offset: 0x00150E59
		// (set) Token: 0x0600806B RID: 32875 RVA: 0x00152C61 File Offset: 0x00150E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MGOCICCJGFE
		{
			get
			{
				return this.mGOCICCJGFE_;
			}
			set
			{
				this.mGOCICCJGFE_ = value;
			}
		}

		// Token: 0x0600806C RID: 32876 RVA: 0x00152C6A File Offset: 0x00150E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGuessChooseCsReq);
		}

		// Token: 0x0600806D RID: 32877 RVA: 0x00152C78 File Offset: 0x00150E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGuessChooseCsReq other)
		{
			return other != null && (other == this || (this.MGOCICCJGFE == other.MGOCICCJGFE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600806E RID: 32878 RVA: 0x00152CA8 File Offset: 0x00150EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MGOCICCJGFE != 0U)
			{
				num ^= this.MGOCICCJGFE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600806F RID: 32879 RVA: 0x00152CE7 File Offset: 0x00150EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008070 RID: 32880 RVA: 0x00152CEF File Offset: 0x00150EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008071 RID: 32881 RVA: 0x00152CF8 File Offset: 0x00150EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MGOCICCJGFE != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MGOCICCJGFE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x00152D2C File Offset: 0x00150F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MGOCICCJGFE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MGOCICCJGFE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x00152D6A File Offset: 0x00150F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGuessChooseCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MGOCICCJGFE != 0U)
			{
				this.MGOCICCJGFE = other.MGOCICCJGFE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008074 RID: 32884 RVA: 0x00152D9B File Offset: 0x00150F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008075 RID: 32885 RVA: 0x00152DA4 File Offset: 0x00150FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MGOCICCJGFE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003115 RID: 12565
		private static readonly MessageParser<MonopolyGuessChooseCsReq> _parser = new MessageParser<MonopolyGuessChooseCsReq>(() => new MonopolyGuessChooseCsReq());

		// Token: 0x04003116 RID: 12566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003117 RID: 12567
		public const int MGOCICCJGFEFieldNumber = 7;

		// Token: 0x04003118 RID: 12568
		private uint mGOCICCJGFE_;
	}
}
