using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CF5 RID: 3317
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PNPLHHNBADF : IMessage<PNPLHHNBADF>, IMessage, IEquatable<PNPLHHNBADF>, IDeepCloneable<PNPLHHNBADF>, IBufferMessage
	{
		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x06009429 RID: 37929 RVA: 0x0018A019 File Offset: 0x00188219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PNPLHHNBADF> Parser
		{
			get
			{
				return PNPLHHNBADF._parser;
			}
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x0600942A RID: 37930 RVA: 0x0018A020 File Offset: 0x00188220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PNPLHHNBADFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x0600942B RID: 37931 RVA: 0x0018A032 File Offset: 0x00188232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PNPLHHNBADF.Descriptor;
			}
		}

		// Token: 0x0600942C RID: 37932 RVA: 0x0018A039 File Offset: 0x00188239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PNPLHHNBADF()
		{
		}

		// Token: 0x0600942D RID: 37933 RVA: 0x0018A044 File Offset: 0x00188244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PNPLHHNBADF(PNPLHHNBADF other) : this()
		{
			this.source_ = other.source_;
			this.rogueAction_ = ((other.rogueAction_ != null) ? other.rogueAction_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600942E RID: 37934 RVA: 0x0018A090 File Offset: 0x00188290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PNPLHHNBADF Clone()
		{
			return new PNPLHHNBADF(this);
		}

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x0600942F RID: 37935 RVA: 0x0018A098 File Offset: 0x00188298
		// (set) Token: 0x06009430 RID: 37936 RVA: 0x0018A0A0 File Offset: 0x001882A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KNAEHLJADLN Source
		{
			get
			{
				return this.source_;
			}
			set
			{
				this.source_ = value;
			}
		}

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x06009431 RID: 37937 RVA: 0x0018A0A9 File Offset: 0x001882A9
		// (set) Token: 0x06009432 RID: 37938 RVA: 0x0018A0B1 File Offset: 0x001882B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FAJCMNEPFKP RogueAction
		{
			get
			{
				return this.rogueAction_;
			}
			set
			{
				this.rogueAction_ = value;
			}
		}

		// Token: 0x06009433 RID: 37939 RVA: 0x0018A0BA File Offset: 0x001882BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PNPLHHNBADF);
		}

		// Token: 0x06009434 RID: 37940 RVA: 0x0018A0C8 File Offset: 0x001882C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PNPLHHNBADF other)
		{
			return other != null && (other == this || (this.Source == other.Source && object.Equals(this.RogueAction, other.RogueAction) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009435 RID: 37941 RVA: 0x0018A118 File Offset: 0x00188318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Source != KNAEHLJADLN.SwordTrainGameSourceTypeNone)
			{
				num ^= this.Source.GetHashCode();
			}
			if (this.rogueAction_ != null)
			{
				num ^= this.RogueAction.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009436 RID: 37942 RVA: 0x0018A173 File Offset: 0x00188373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009437 RID: 37943 RVA: 0x0018A17B File Offset: 0x0018837B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009438 RID: 37944 RVA: 0x0018A184 File Offset: 0x00188384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Source != KNAEHLJADLN.SwordTrainGameSourceTypeNone)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Source);
			}
			if (this.rogueAction_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueAction);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009439 RID: 37945 RVA: 0x0018A1DC File Offset: 0x001883DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Source != KNAEHLJADLN.SwordTrainGameSourceTypeNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Source);
			}
			if (this.rogueAction_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAction);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600943A RID: 37946 RVA: 0x0018A234 File Offset: 0x00188434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PNPLHHNBADF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Source != KNAEHLJADLN.SwordTrainGameSourceTypeNone)
			{
				this.Source = other.Source;
			}
			if (other.rogueAction_ != null)
			{
				if (this.rogueAction_ == null)
				{
					this.RogueAction = new FAJCMNEPFKP();
				}
				this.RogueAction.MergeFrom(other.RogueAction);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600943B RID: 37947 RVA: 0x0018A29C File Offset: 0x0018849C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600943C RID: 37948 RVA: 0x0018A2A8 File Offset: 0x001884A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueAction_ == null)
						{
							this.RogueAction = new FAJCMNEPFKP();
						}
						input.ReadMessage(this.RogueAction);
					}
				}
				else
				{
					this.Source = (KNAEHLJADLN)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400396A RID: 14698
		private static readonly MessageParser<PNPLHHNBADF> _parser = new MessageParser<PNPLHHNBADF>(() => new PNPLHHNBADF());

		// Token: 0x0400396B RID: 14699
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400396C RID: 14700
		public const int SourceFieldNumber = 1;

		// Token: 0x0400396D RID: 14701
		private KNAEHLJADLN source_;

		// Token: 0x0400396E RID: 14702
		public const int RogueActionFieldNumber = 7;

		// Token: 0x0400396F RID: 14703
		private FAJCMNEPFKP rogueAction_;
	}
}
