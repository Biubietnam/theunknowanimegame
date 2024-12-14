using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E6F RID: 3695
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueDebugMessageScNotify : IMessage<RogueDebugMessageScNotify>, IMessage, IEquatable<RogueDebugMessageScNotify>, IDeepCloneable<RogueDebugMessageScNotify>, IBufferMessage
	{
		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x0600A4D6 RID: 42198 RVA: 0x001BB1FB File Offset: 0x001B93FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueDebugMessageScNotify> Parser
		{
			get
			{
				return RogueDebugMessageScNotify._parser;
			}
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x0600A4D7 RID: 42199 RVA: 0x001BB202 File Offset: 0x001B9402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueDebugMessageScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x0600A4D8 RID: 42200 RVA: 0x001BB214 File Offset: 0x001B9414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueDebugMessageScNotify.Descriptor;
			}
		}

		// Token: 0x0600A4D9 RID: 42201 RVA: 0x001BB21B File Offset: 0x001B941B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDebugMessageScNotify()
		{
		}

		// Token: 0x0600A4DA RID: 42202 RVA: 0x001BB239 File Offset: 0x001B9439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDebugMessageScNotify(RogueDebugMessageScNotify other) : this()
		{
			this.lEHBFICLHON_ = other.lEHBFICLHON_;
			this.type_ = other.type_;
			this.nCAGBFAKCNI_ = other.nCAGBFAKCNI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4DB RID: 42203 RVA: 0x001BB276 File Offset: 0x001B9476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDebugMessageScNotify Clone()
		{
			return new RogueDebugMessageScNotify(this);
		}

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x0600A4DC RID: 42204 RVA: 0x001BB27E File Offset: 0x001B947E
		// (set) Token: 0x0600A4DD RID: 42205 RVA: 0x001BB286 File Offset: 0x001B9486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LEHBFICLHON
		{
			get
			{
				return this.lEHBFICLHON_;
			}
			set
			{
				this.lEHBFICLHON_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x0600A4DE RID: 42206 RVA: 0x001BB299 File Offset: 0x001B9499
		// (set) Token: 0x0600A4DF RID: 42207 RVA: 0x001BB2A1 File Offset: 0x001B94A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KLGILFNFKEO Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x0600A4E0 RID: 42208 RVA: 0x001BB2AA File Offset: 0x001B94AA
		// (set) Token: 0x0600A4E1 RID: 42209 RVA: 0x001BB2B2 File Offset: 0x001B94B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string NCAGBFAKCNI
		{
			get
			{
				return this.nCAGBFAKCNI_;
			}
			set
			{
				this.nCAGBFAKCNI_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600A4E2 RID: 42210 RVA: 0x001BB2C5 File Offset: 0x001B94C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueDebugMessageScNotify);
		}

		// Token: 0x0600A4E3 RID: 42211 RVA: 0x001BB2D4 File Offset: 0x001B94D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueDebugMessageScNotify other)
		{
			return other != null && (other == this || (!(this.LEHBFICLHON != other.LEHBFICLHON) && this.Type == other.Type && !(this.NCAGBFAKCNI != other.NCAGBFAKCNI) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4E4 RID: 42212 RVA: 0x001BB338 File Offset: 0x001B9538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LEHBFICLHON.Length != 0)
			{
				num ^= this.LEHBFICLHON.GetHashCode();
			}
			if (this.Type != KLGILFNFKEO.RogueDebugMessageTypeNone)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.NCAGBFAKCNI.Length != 0)
			{
				num ^= this.NCAGBFAKCNI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A4E5 RID: 42213 RVA: 0x001BB3B3 File Offset: 0x001B95B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A4E6 RID: 42214 RVA: 0x001BB3BB File Offset: 0x001B95BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4E7 RID: 42215 RVA: 0x001BB3C4 File Offset: 0x001B95C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != KLGILFNFKEO.RogueDebugMessageTypeNone)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Type);
			}
			if (this.LEHBFICLHON.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.LEHBFICLHON);
			}
			if (this.NCAGBFAKCNI.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.NCAGBFAKCNI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4E8 RID: 42216 RVA: 0x001BB444 File Offset: 0x001B9644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LEHBFICLHON.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LEHBFICLHON);
			}
			if (this.Type != KLGILFNFKEO.RogueDebugMessageTypeNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.NCAGBFAKCNI.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.NCAGBFAKCNI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A4E9 RID: 42217 RVA: 0x001BB4BC File Offset: 0x001B96BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueDebugMessageScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LEHBFICLHON.Length != 0)
			{
				this.LEHBFICLHON = other.LEHBFICLHON;
			}
			if (other.Type != KLGILFNFKEO.RogueDebugMessageTypeNone)
			{
				this.Type = other.Type;
			}
			if (other.NCAGBFAKCNI.Length != 0)
			{
				this.NCAGBFAKCNI = other.NCAGBFAKCNI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A4EA RID: 42218 RVA: 0x001BB52A File Offset: 0x001B972A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4EB RID: 42219 RVA: 0x001BB534 File Offset: 0x001B9734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 34U)
					{
						if (num != 82U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NCAGBFAKCNI = input.ReadString();
						}
					}
					else
					{
						this.LEHBFICLHON = input.ReadString();
					}
				}
				else
				{
					this.Type = (KLGILFNFKEO)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400435A RID: 17242
		private static readonly MessageParser<RogueDebugMessageScNotify> _parser = new MessageParser<RogueDebugMessageScNotify>(() => new RogueDebugMessageScNotify());

		// Token: 0x0400435B RID: 17243
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400435C RID: 17244
		public const int LEHBFICLHONFieldNumber = 4;

		// Token: 0x0400435D RID: 17245
		private string lEHBFICLHON_ = "";

		// Token: 0x0400435E RID: 17246
		public const int TypeFieldNumber = 3;

		// Token: 0x0400435F RID: 17247
		private KLGILFNFKEO type_;

		// Token: 0x04004360 RID: 17248
		public const int NCAGBFAKCNIFieldNumber = 10;

		// Token: 0x04004361 RID: 17249
		private string nCAGBFAKCNI_ = "";
	}
}
