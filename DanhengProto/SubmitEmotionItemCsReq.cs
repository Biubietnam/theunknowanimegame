using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011F7 RID: 4599
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubmitEmotionItemCsReq : IMessage<SubmitEmotionItemCsReq>, IMessage, IEquatable<SubmitEmotionItemCsReq>, IDeepCloneable<SubmitEmotionItemCsReq>, IBufferMessage
	{
		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x0600CD8D RID: 52621 RVA: 0x00227B4B File Offset: 0x00225D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubmitEmotionItemCsReq> Parser
		{
			get
			{
				return SubmitEmotionItemCsReq._parser;
			}
		}

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x0600CD8E RID: 52622 RVA: 0x00227B52 File Offset: 0x00225D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SubmitEmotionItemCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x0600CD8F RID: 52623 RVA: 0x00227B64 File Offset: 0x00225D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitEmotionItemCsReq.Descriptor;
			}
		}

		// Token: 0x0600CD90 RID: 52624 RVA: 0x00227B6B File Offset: 0x00225D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitEmotionItemCsReq()
		{
		}

		// Token: 0x0600CD91 RID: 52625 RVA: 0x00227B74 File Offset: 0x00225D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitEmotionItemCsReq(SubmitEmotionItemCsReq other) : this()
		{
			this.scriptId_ = other.scriptId_;
			this.itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
			this.fPPEFBKBFDD_ = other.fPPEFBKBFDD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD92 RID: 52626 RVA: 0x00227BCC File Offset: 0x00225DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitEmotionItemCsReq Clone()
		{
			return new SubmitEmotionItemCsReq(this);
		}

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x0600CD93 RID: 52627 RVA: 0x00227BD4 File Offset: 0x00225DD4
		// (set) Token: 0x0600CD94 RID: 52628 RVA: 0x00227BDC File Offset: 0x00225DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x0600CD95 RID: 52629 RVA: 0x00227BE5 File Offset: 0x00225DE5
		// (set) Token: 0x0600CD96 RID: 52630 RVA: 0x00227BED File Offset: 0x00225DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ItemList
		{
			get
			{
				return this.itemList_;
			}
			set
			{
				this.itemList_ = value;
			}
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x0600CD97 RID: 52631 RVA: 0x00227BF6 File Offset: 0x00225DF6
		// (set) Token: 0x0600CD98 RID: 52632 RVA: 0x00227BFE File Offset: 0x00225DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FPPEFBKBFDD
		{
			get
			{
				return this.fPPEFBKBFDD_;
			}
			set
			{
				this.fPPEFBKBFDD_ = value;
			}
		}

		// Token: 0x0600CD99 RID: 52633 RVA: 0x00227C07 File Offset: 0x00225E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitEmotionItemCsReq);
		}

		// Token: 0x0600CD9A RID: 52634 RVA: 0x00227C18 File Offset: 0x00225E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitEmotionItemCsReq other)
		{
			return other != null && (other == this || (this.ScriptId == other.ScriptId && object.Equals(this.ItemList, other.ItemList) && this.FPPEFBKBFDD == other.FPPEFBKBFDD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD9B RID: 52635 RVA: 0x00227C78 File Offset: 0x00225E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this.itemList_ != null)
			{
				num ^= this.ItemList.GetHashCode();
			}
			if (this.FPPEFBKBFDD != 0U)
			{
				num ^= this.FPPEFBKBFDD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD9C RID: 52636 RVA: 0x00227CE6 File Offset: 0x00225EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CD9D RID: 52637 RVA: 0x00227CEE File Offset: 0x00225EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD9E RID: 52638 RVA: 0x00227CF8 File Offset: 0x00225EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.itemList_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ItemList);
			}
			if (this.FPPEFBKBFDD != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.FPPEFBKBFDD);
			}
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ScriptId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD9F RID: 52639 RVA: 0x00227D70 File Offset: 0x00225F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this.itemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemList);
			}
			if (this.FPPEFBKBFDD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FPPEFBKBFDD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CDA0 RID: 52640 RVA: 0x00227DE0 File Offset: 0x00225FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitEmotionItemCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.itemList_ != null)
			{
				if (this.itemList_ == null)
				{
					this.ItemList = new ItemList();
				}
				this.ItemList.MergeFrom(other.ItemList);
			}
			if (other.FPPEFBKBFDD != 0U)
			{
				this.FPPEFBKBFDD = other.FPPEFBKBFDD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CDA1 RID: 52641 RVA: 0x00227E5C File Offset: 0x0022605C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDA2 RID: 52642 RVA: 0x00227E68 File Offset: 0x00226068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 64U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ScriptId = input.ReadUInt32();
						}
					}
					else
					{
						this.FPPEFBKBFDD = input.ReadUInt32();
					}
				}
				else
				{
					if (this.itemList_ == null)
					{
						this.ItemList = new ItemList();
					}
					input.ReadMessage(this.ItemList);
				}
			}
		}

		// Token: 0x040052E3 RID: 21219
		private static readonly MessageParser<SubmitEmotionItemCsReq> _parser = new MessageParser<SubmitEmotionItemCsReq>(() => new SubmitEmotionItemCsReq());

		// Token: 0x040052E4 RID: 21220
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052E5 RID: 21221
		public const int ScriptIdFieldNumber = 13;

		// Token: 0x040052E6 RID: 21222
		private uint scriptId_;

		// Token: 0x040052E7 RID: 21223
		public const int ItemListFieldNumber = 5;

		// Token: 0x040052E8 RID: 21224
		private ItemList itemList_;

		// Token: 0x040052E9 RID: 21225
		public const int FPPEFBKBFDDFieldNumber = 8;

		// Token: 0x040052EA RID: 21226
		private uint fPPEFBKBFDD_;
	}
}
