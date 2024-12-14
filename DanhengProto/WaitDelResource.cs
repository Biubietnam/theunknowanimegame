using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001419 RID: 5145
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WaitDelResource : IMessage<WaitDelResource>, IMessage, IEquatable<WaitDelResource>, IDeepCloneable<WaitDelResource>, IBufferMessage
	{
		// Token: 0x17004071 RID: 16497
		// (get) Token: 0x0600E585 RID: 58757 RVA: 0x00262418 File Offset: 0x00260618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WaitDelResource> Parser
		{
			get
			{
				return WaitDelResource._parser;
			}
		}

		// Token: 0x17004072 RID: 16498
		// (get) Token: 0x0600E586 RID: 58758 RVA: 0x0026241F File Offset: 0x0026061F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WaitDelResourceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004073 RID: 16499
		// (get) Token: 0x0600E587 RID: 58759 RVA: 0x00262431 File Offset: 0x00260631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WaitDelResource.Descriptor;
			}
		}

		// Token: 0x0600E588 RID: 58760 RVA: 0x00262438 File Offset: 0x00260638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaitDelResource()
		{
		}

		// Token: 0x0600E589 RID: 58761 RVA: 0x00262440 File Offset: 0x00260640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaitDelResource(WaitDelResource other) : this()
		{
			this.num_ = other.num_;
			this.tid_ = other.tid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E58A RID: 58762 RVA: 0x00262471 File Offset: 0x00260671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaitDelResource Clone()
		{
			return new WaitDelResource(this);
		}

		// Token: 0x17004074 RID: 16500
		// (get) Token: 0x0600E58B RID: 58763 RVA: 0x00262479 File Offset: 0x00260679
		// (set) Token: 0x0600E58C RID: 58764 RVA: 0x00262481 File Offset: 0x00260681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17004075 RID: 16501
		// (get) Token: 0x0600E58D RID: 58765 RVA: 0x0026248A File Offset: 0x0026068A
		// (set) Token: 0x0600E58E RID: 58766 RVA: 0x00262492 File Offset: 0x00260692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Tid
		{
			get
			{
				return this.tid_;
			}
			set
			{
				this.tid_ = value;
			}
		}

		// Token: 0x0600E58F RID: 58767 RVA: 0x0026249B File Offset: 0x0026069B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WaitDelResource);
		}

		// Token: 0x0600E590 RID: 58768 RVA: 0x002624A9 File Offset: 0x002606A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WaitDelResource other)
		{
			return other != null && (other == this || (this.Num == other.Num && this.Tid == other.Tid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E591 RID: 58769 RVA: 0x002624E8 File Offset: 0x002606E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.Tid != 0U)
			{
				num ^= this.Tid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E592 RID: 58770 RVA: 0x00262540 File Offset: 0x00260740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E593 RID: 58771 RVA: 0x00262548 File Offset: 0x00260748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E594 RID: 58772 RVA: 0x00262554 File Offset: 0x00260754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Tid != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Tid);
			}
			if (this.Num != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E595 RID: 58773 RVA: 0x002625AC File Offset: 0x002607AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this.Tid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E596 RID: 58774 RVA: 0x00262604 File Offset: 0x00260804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WaitDelResource other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			if (other.Tid != 0U)
			{
				this.Tid = other.Tid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E597 RID: 58775 RVA: 0x00262654 File Offset: 0x00260854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E598 RID: 58776 RVA: 0x00262660 File Offset: 0x00260860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Num = input.ReadUInt32();
					}
				}
				else
				{
					this.Tid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005B27 RID: 23335
		private static readonly MessageParser<WaitDelResource> _parser = new MessageParser<WaitDelResource>(() => new WaitDelResource());

		// Token: 0x04005B28 RID: 23336
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B29 RID: 23337
		public const int NumFieldNumber = 15;

		// Token: 0x04005B2A RID: 23338
		private uint num_;

		// Token: 0x04005B2B RID: 23339
		public const int TidFieldNumber = 1;

		// Token: 0x04005B2C RID: 23340
		private uint tid_;
	}
}
