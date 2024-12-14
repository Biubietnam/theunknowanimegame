using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004F9 RID: 1273
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FAFOJMLECPG : IMessage<FAFOJMLECPG>, IMessage, IEquatable<FAFOJMLECPG>, IDeepCloneable<FAFOJMLECPG>, IBufferMessage
	{
		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x0009BEEC File Offset: 0x0009A0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FAFOJMLECPG> Parser
		{
			get
			{
				return FAFOJMLECPG._parser;
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x060038E6 RID: 14566 RVA: 0x0009BEF3 File Offset: 0x0009A0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FAFOJMLECPGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x0009BF05 File Offset: 0x0009A105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FAFOJMLECPG.Descriptor;
			}
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0009BF0C File Offset: 0x0009A10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FAFOJMLECPG()
		{
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x0009BF14 File Offset: 0x0009A114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FAFOJMLECPG(FAFOJMLECPG other) : this()
		{
			this.mALKHNFHFAE_ = ((other.mALKHNFHFAE_ != null) ? other.mALKHNFHFAE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x0009BF49 File Offset: 0x0009A149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FAFOJMLECPG Clone()
		{
			return new FAFOJMLECPG(this);
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x0009BF51 File Offset: 0x0009A151
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x0009BF59 File Offset: 0x0009A159
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

		// Token: 0x060038ED RID: 14573 RVA: 0x0009BF62 File Offset: 0x0009A162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FAFOJMLECPG);
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x0009BF70 File Offset: 0x0009A170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FAFOJMLECPG other)
		{
			return other != null && (other == this || (object.Equals(this.MALKHNFHFAE, other.MALKHNFHFAE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x0009BFA4 File Offset: 0x0009A1A4
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

		// Token: 0x060038F0 RID: 14576 RVA: 0x0009BFE0 File Offset: 0x0009A1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x0009BFE8 File Offset: 0x0009A1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x0009BFF1 File Offset: 0x0009A1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mALKHNFHFAE_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MALKHNFHFAE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x0009C024 File Offset: 0x0009A224
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

		// Token: 0x060038F4 RID: 14580 RVA: 0x0009C064 File Offset: 0x0009A264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FAFOJMLECPG other)
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

		// Token: 0x060038F5 RID: 14581 RVA: 0x0009C0B8 File Offset: 0x0009A2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x0009C0C4 File Offset: 0x0009A2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
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

		// Token: 0x04001693 RID: 5779
		private static readonly MessageParser<FAFOJMLECPG> _parser = new MessageParser<FAFOJMLECPG>(() => new FAFOJMLECPG());

		// Token: 0x04001694 RID: 5780
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001695 RID: 5781
		public const int MALKHNFHFAEFieldNumber = 4;

		// Token: 0x04001696 RID: 5782
		private DPCAMGELHBP mALKHNFHFAE_;
	}
}
