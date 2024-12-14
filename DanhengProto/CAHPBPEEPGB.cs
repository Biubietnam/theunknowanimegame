using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000159 RID: 345
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CAHPBPEEPGB : IMessage<CAHPBPEEPGB>, IMessage, IEquatable<CAHPBPEEPGB>, IDeepCloneable<CAHPBPEEPGB>, IBufferMessage
	{
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0002D598 File Offset: 0x0002B798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CAHPBPEEPGB> Parser
		{
			get
			{
				return CAHPBPEEPGB._parser;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x0002D59F File Offset: 0x0002B79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CAHPBPEEPGBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0002D5B1 File Offset: 0x0002B7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CAHPBPEEPGB.Descriptor;
			}
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0002D5B8 File Offset: 0x0002B7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CAHPBPEEPGB()
		{
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0002D5C0 File Offset: 0x0002B7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CAHPBPEEPGB(CAHPBPEEPGB other) : this()
		{
			this.mALKHNFHFAE_ = ((other.mALKHNFHFAE_ != null) ? other.mALKHNFHFAE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0002D5F5 File Offset: 0x0002B7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CAHPBPEEPGB Clone()
		{
			return new CAHPBPEEPGB(this);
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0002D5FD File Offset: 0x0002B7FD
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0002D605 File Offset: 0x0002B805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPCAMGELHBP MALKHNFHFAE
		{
			get
			{
				return this.mALKHNFHFAE_;
			}
			set
			{
				this.mALKHNFHFAE_ = value;
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0002D60E File Offset: 0x0002B80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CAHPBPEEPGB);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0002D61C File Offset: 0x0002B81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CAHPBPEEPGB other)
		{
			return other != null && (other == this || (object.Equals(this.MALKHNFHFAE, other.MALKHNFHFAE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0002D650 File Offset: 0x0002B850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.mALKHNFHFAE_ != null)
			{
				num ^= this.MALKHNFHFAE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0002D68C File Offset: 0x0002B88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0002D694 File Offset: 0x0002B894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0002D69D File Offset: 0x0002B89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mALKHNFHFAE_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MALKHNFHFAE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0002D6D0 File Offset: 0x0002B8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.mALKHNFHFAE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MALKHNFHFAE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0002D710 File Offset: 0x0002B910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CAHPBPEEPGB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.mALKHNFHFAE_ != null)
			{
				if (this.mALKHNFHFAE_ == null)
				{
					this.MALKHNFHFAE = new DPCAMGELHBP();
				}
				this.MALKHNFHFAE.MergeFrom(other.MALKHNFHFAE);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0002D764 File Offset: 0x0002B964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0002D770 File Offset: 0x0002B970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.mALKHNFHFAE_ == null)
					{
						this.MALKHNFHFAE = new DPCAMGELHBP();
					}
					input.ReadMessage(this.MALKHNFHFAE);
				}
			}
		}

		// Token: 0x0400069C RID: 1692
		private static readonly MessageParser<CAHPBPEEPGB> _parser = new MessageParser<CAHPBPEEPGB>(() => new CAHPBPEEPGB());

		// Token: 0x0400069D RID: 1693
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400069E RID: 1694
		public const int MALKHNFHFAEFieldNumber = 14;

		// Token: 0x0400069F RID: 1695
		private DPCAMGELHBP mALKHNFHFAE_;
	}
}
