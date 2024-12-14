using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200098F RID: 2447
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KDDJNOPHPJF : IMessage<KDDJNOPHPJF>, IMessage, IEquatable<KDDJNOPHPJF>, IDeepCloneable<KDDJNOPHPJF>, IBufferMessage
	{
		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x06006D82 RID: 28034 RVA: 0x00124DF0 File Offset: 0x00122FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KDDJNOPHPJF> Parser
		{
			get
			{
				return KDDJNOPHPJF._parser;
			}
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x06006D83 RID: 28035 RVA: 0x00124DF7 File Offset: 0x00122FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KDDJNOPHPJFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x06006D84 RID: 28036 RVA: 0x00124E09 File Offset: 0x00123009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KDDJNOPHPJF.Descriptor;
			}
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x00124E10 File Offset: 0x00123010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KDDJNOPHPJF()
		{
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x00124E18 File Offset: 0x00123018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KDDJNOPHPJF(KDDJNOPHPJF other) : this()
		{
			this.pIOHFPLOJJL_ = ((other.pIOHFPLOJJL_ != null) ? other.pIOHFPLOJJL_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D87 RID: 28039 RVA: 0x00124E4D File Offset: 0x0012304D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KDDJNOPHPJF Clone()
		{
			return new KDDJNOPHPJF(this);
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x06006D88 RID: 28040 RVA: 0x00124E55 File Offset: 0x00123055
		// (set) Token: 0x06006D89 RID: 28041 RVA: 0x00124E5D File Offset: 0x0012305D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FCGOPFMEGIE PIOHFPLOJJL
		{
			get
			{
				return this.pIOHFPLOJJL_;
			}
			set
			{
				this.pIOHFPLOJJL_ = value;
			}
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x00124E66 File Offset: 0x00123066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KDDJNOPHPJF);
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x00124E74 File Offset: 0x00123074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KDDJNOPHPJF other)
		{
			return other != null && (other == this || (object.Equals(this.PIOHFPLOJJL, other.PIOHFPLOJJL) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x00124EA8 File Offset: 0x001230A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pIOHFPLOJJL_ != null)
			{
				num ^= this.PIOHFPLOJJL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x00124EE4 File Offset: 0x001230E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x00124EEC File Offset: 0x001230EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x00124EF5 File Offset: 0x001230F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pIOHFPLOJJL_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PIOHFPLOJJL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x00124F28 File Offset: 0x00123128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pIOHFPLOJJL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PIOHFPLOJJL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x00124F68 File Offset: 0x00123168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KDDJNOPHPJF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pIOHFPLOJJL_ != null)
			{
				if (this.pIOHFPLOJJL_ == null)
				{
					this.PIOHFPLOJJL = new FCGOPFMEGIE();
				}
				this.PIOHFPLOJJL.MergeFrom(other.PIOHFPLOJJL);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D92 RID: 28050 RVA: 0x00124FBC File Offset: 0x001231BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x00124FC8 File Offset: 0x001231C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.pIOHFPLOJJL_ == null)
					{
						this.PIOHFPLOJJL = new FCGOPFMEGIE();
					}
					input.ReadMessage(this.PIOHFPLOJJL);
				}
			}
		}

		// Token: 0x04002A1A RID: 10778
		private static readonly MessageParser<KDDJNOPHPJF> _parser = new MessageParser<KDDJNOPHPJF>(() => new KDDJNOPHPJF());

		// Token: 0x04002A1B RID: 10779
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A1C RID: 10780
		public const int PIOHFPLOJJLFieldNumber = 1;

		// Token: 0x04002A1D RID: 10781
		private FCGOPFMEGIE pIOHFPLOJJL_;
	}
}
