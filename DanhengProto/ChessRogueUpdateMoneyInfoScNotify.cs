using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002B7 RID: 695
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueUpdateMoneyInfoScNotify : IMessage<ChessRogueUpdateMoneyInfoScNotify>, IMessage, IEquatable<ChessRogueUpdateMoneyInfoScNotify>, IDeepCloneable<ChessRogueUpdateMoneyInfoScNotify>, IBufferMessage
	{
		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x000587F7 File Offset: 0x000569F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueUpdateMoneyInfoScNotify> Parser
		{
			get
			{
				return ChessRogueUpdateMoneyInfoScNotify._parser;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x000587FE File Offset: 0x000569FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateMoneyInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x00058810 File Offset: 0x00056A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueUpdateMoneyInfoScNotify.Descriptor;
			}
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00058817 File Offset: 0x00056A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateMoneyInfoScNotify()
		{
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0005881F File Offset: 0x00056A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateMoneyInfoScNotify(ChessRogueUpdateMoneyInfoScNotify other) : this()
		{
			this.virtualItemInfo_ = ((other.virtualItemInfo_ != null) ? other.virtualItemInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00058854 File Offset: 0x00056A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateMoneyInfoScNotify Clone()
		{
			return new ChessRogueUpdateMoneyInfoScNotify(this);
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x0005885C File Offset: 0x00056A5C
		// (set) Token: 0x06001EFD RID: 7933 RVA: 0x00058864 File Offset: 0x00056A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueVirtualItem VirtualItemInfo
		{
			get
			{
				return this.virtualItemInfo_;
			}
			set
			{
				this.virtualItemInfo_ = value;
			}
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x0005886D File Offset: 0x00056A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueUpdateMoneyInfoScNotify);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x0005887B File Offset: 0x00056A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueUpdateMoneyInfoScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.VirtualItemInfo, other.VirtualItemInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000588B0 File Offset: 0x00056AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.virtualItemInfo_ != null)
			{
				num ^= this.VirtualItemInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x000588EC File Offset: 0x00056AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x000588F4 File Offset: 0x00056AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x000588FD File Offset: 0x00056AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.virtualItemInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.VirtualItemInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00058930 File Offset: 0x00056B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.virtualItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VirtualItemInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00058970 File Offset: 0x00056B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueUpdateMoneyInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.virtualItemInfo_ != null)
			{
				if (this.virtualItemInfo_ == null)
				{
					this.VirtualItemInfo = new RogueVirtualItem();
				}
				this.VirtualItemInfo.MergeFrom(other.VirtualItemInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x000589C4 File Offset: 0x00056BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x000589D0 File Offset: 0x00056BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.virtualItemInfo_ == null)
					{
						this.VirtualItemInfo = new RogueVirtualItem();
					}
					input.ReadMessage(this.VirtualItemInfo);
				}
			}
		}

		// Token: 0x04000CDF RID: 3295
		private static readonly MessageParser<ChessRogueUpdateMoneyInfoScNotify> _parser = new MessageParser<ChessRogueUpdateMoneyInfoScNotify>(() => new ChessRogueUpdateMoneyInfoScNotify());

		// Token: 0x04000CE0 RID: 3296
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CE1 RID: 3297
		public const int VirtualItemInfoFieldNumber = 11;

		// Token: 0x04000CE2 RID: 3298
		private RogueVirtualItem virtualItemInfo_;
	}
}
