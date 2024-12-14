using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009E7 RID: 2535
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LCCFLFOAKMI : IMessage<LCCFLFOAKMI>, IMessage, IEquatable<LCCFLFOAKMI>, IDeepCloneable<LCCFLFOAKMI>, IBufferMessage
	{
		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x06007090 RID: 28816 RVA: 0x0012C318 File Offset: 0x0012A518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LCCFLFOAKMI> Parser
		{
			get
			{
				return LCCFLFOAKMI._parser;
			}
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06007091 RID: 28817 RVA: 0x0012C31F File Offset: 0x0012A51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LCCFLFOAKMIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x06007092 RID: 28818 RVA: 0x0012C331 File Offset: 0x0012A531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LCCFLFOAKMI.Descriptor;
			}
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x0012C338 File Offset: 0x0012A538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LCCFLFOAKMI()
		{
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x0012C340 File Offset: 0x0012A540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LCCFLFOAKMI(LCCFLFOAKMI other) : this()
		{
			this.oBMGEJKCHFN_ = ((other.oBMGEJKCHFN_ != null) ? other.oBMGEJKCHFN_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x0012C375 File Offset: 0x0012A575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LCCFLFOAKMI Clone()
		{
			return new LCCFLFOAKMI(this);
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x06007096 RID: 28822 RVA: 0x0012C37D File Offset: 0x0012A57D
		// (set) Token: 0x06007097 RID: 28823 RVA: 0x0012C385 File Offset: 0x0012A585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KNGCGMILGKE OBMGEJKCHFN
		{
			get
			{
				return this.oBMGEJKCHFN_;
			}
			set
			{
				this.oBMGEJKCHFN_ = value;
			}
		}

		// Token: 0x06007098 RID: 28824 RVA: 0x0012C38E File Offset: 0x0012A58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LCCFLFOAKMI);
		}

		// Token: 0x06007099 RID: 28825 RVA: 0x0012C39C File Offset: 0x0012A59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LCCFLFOAKMI other)
		{
			return other != null && (other == this || (object.Equals(this.OBMGEJKCHFN, other.OBMGEJKCHFN) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x0012C3D0 File Offset: 0x0012A5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.oBMGEJKCHFN_ != null)
			{
				num ^= this.OBMGEJKCHFN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x0012C40C File Offset: 0x0012A60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x0012C414 File Offset: 0x0012A614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x0012C41D File Offset: 0x0012A61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.oBMGEJKCHFN_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.OBMGEJKCHFN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600709E RID: 28830 RVA: 0x0012C450 File Offset: 0x0012A650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.oBMGEJKCHFN_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OBMGEJKCHFN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x0012C490 File Offset: 0x0012A690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LCCFLFOAKMI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.oBMGEJKCHFN_ != null)
			{
				if (this.oBMGEJKCHFN_ == null)
				{
					this.OBMGEJKCHFN = new KNGCGMILGKE();
				}
				this.OBMGEJKCHFN.MergeFrom(other.OBMGEJKCHFN);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x0012C4E4 File Offset: 0x0012A6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x0012C4F0 File Offset: 0x0012A6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.oBMGEJKCHFN_ == null)
					{
						this.OBMGEJKCHFN = new KNGCGMILGKE();
					}
					input.ReadMessage(this.OBMGEJKCHFN);
				}
			}
		}

		// Token: 0x04002B69 RID: 11113
		private static readonly MessageParser<LCCFLFOAKMI> _parser = new MessageParser<LCCFLFOAKMI>(() => new LCCFLFOAKMI());

		// Token: 0x04002B6A RID: 11114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B6B RID: 11115
		public const int OBMGEJKCHFNFieldNumber = 13;

		// Token: 0x04002B6C RID: 11116
		private KNGCGMILGKE oBMGEJKCHFN_;
	}
}
