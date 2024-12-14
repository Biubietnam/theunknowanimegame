using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000323 RID: 803
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ComposeSelectedRelicScRsp : IMessage<ComposeSelectedRelicScRsp>, IMessage, IEquatable<ComposeSelectedRelicScRsp>, IDeepCloneable<ComposeSelectedRelicScRsp>, IBufferMessage
	{
		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x0006637F File Offset: 0x0006457F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ComposeSelectedRelicScRsp> Parser
		{
			get
			{
				return ComposeSelectedRelicScRsp._parser;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x00066386 File Offset: 0x00064586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ComposeSelectedRelicScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x00066398 File Offset: 0x00064598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ComposeSelectedRelicScRsp.Descriptor;
			}
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0006639F File Offset: 0x0006459F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeSelectedRelicScRsp()
		{
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x000663A8 File Offset: 0x000645A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeSelectedRelicScRsp(ComposeSelectedRelicScRsp other) : this()
		{
			this.returnItemList_ = ((other.returnItemList_ != null) ? other.returnItemList_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.composeId_ = other.composeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00066400 File Offset: 0x00064600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeSelectedRelicScRsp Clone()
		{
			return new ComposeSelectedRelicScRsp(this);
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x00066408 File Offset: 0x00064608
		// (set) Token: 0x06002409 RID: 9225 RVA: 0x00066410 File Offset: 0x00064610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ReturnItemList
		{
			get
			{
				return this.returnItemList_;
			}
			set
			{
				this.returnItemList_ = value;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x00066419 File Offset: 0x00064619
		// (set) Token: 0x0600240B RID: 9227 RVA: 0x00066421 File Offset: 0x00064621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x0006642A File Offset: 0x0006462A
		// (set) Token: 0x0600240D RID: 9229 RVA: 0x00066432 File Offset: 0x00064632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ComposeId
		{
			get
			{
				return this.composeId_;
			}
			set
			{
				this.composeId_ = value;
			}
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0006643B File Offset: 0x0006463B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ComposeSelectedRelicScRsp);
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x0006644C File Offset: 0x0006464C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ComposeSelectedRelicScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.ReturnItemList, other.ReturnItemList) && this.Retcode == other.Retcode && this.ComposeId == other.ComposeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x000664AC File Offset: 0x000646AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.returnItemList_ != null)
			{
				num ^= this.ReturnItemList.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ComposeId != 0U)
			{
				num ^= this.ComposeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0006651A File Offset: 0x0006471A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00066522 File Offset: 0x00064722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x0006652C File Offset: 0x0006472C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.returnItemList_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ReturnItemList);
			}
			if (this.ComposeId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ComposeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x000665A4 File Offset: 0x000647A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.returnItemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReturnItemList);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ComposeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ComposeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00066614 File Offset: 0x00064814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ComposeSelectedRelicScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.returnItemList_ != null)
			{
				if (this.returnItemList_ == null)
				{
					this.ReturnItemList = new ItemList();
				}
				this.ReturnItemList.MergeFrom(other.ReturnItemList);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ComposeId != 0U)
			{
				this.ComposeId = other.ComposeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00066690 File Offset: 0x00064890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x0006669C File Offset: 0x0006489C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 74U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ComposeId = input.ReadUInt32();
						}
					}
					else
					{
						if (this.returnItemList_ == null)
						{
							this.ReturnItemList = new ItemList();
						}
						input.ReadMessage(this.ReturnItemList);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000EC3 RID: 3779
		private static readonly MessageParser<ComposeSelectedRelicScRsp> _parser = new MessageParser<ComposeSelectedRelicScRsp>(() => new ComposeSelectedRelicScRsp());

		// Token: 0x04000EC4 RID: 3780
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EC5 RID: 3781
		public const int ReturnItemListFieldNumber = 9;

		// Token: 0x04000EC6 RID: 3782
		private ItemList returnItemList_;

		// Token: 0x04000EC7 RID: 3783
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04000EC8 RID: 3784
		private uint retcode_;

		// Token: 0x04000EC9 RID: 3785
		public const int ComposeIdFieldNumber = 13;

		// Token: 0x04000ECA RID: 3786
		private uint composeId_;
	}
}
