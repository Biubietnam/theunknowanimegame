using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012A1 RID: 4769
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueVirtualItemInfoScNotify : IMessage<SyncRogueVirtualItemInfoScNotify>, IMessage, IEquatable<SyncRogueVirtualItemInfoScNotify>, IDeepCloneable<SyncRogueVirtualItemInfoScNotify>, IBufferMessage
	{
		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x0600D4C2 RID: 54466 RVA: 0x002381EB File Offset: 0x002363EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueVirtualItemInfoScNotify> Parser
		{
			get
			{
				return SyncRogueVirtualItemInfoScNotify._parser;
			}
		}

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x0600D4C3 RID: 54467 RVA: 0x002381F2 File Offset: 0x002363F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueVirtualItemInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x0600D4C4 RID: 54468 RVA: 0x00238204 File Offset: 0x00236404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueVirtualItemInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600D4C5 RID: 54469 RVA: 0x0023820B File Offset: 0x0023640B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueVirtualItemInfoScNotify()
		{
		}

		// Token: 0x0600D4C6 RID: 54470 RVA: 0x00238213 File Offset: 0x00236413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueVirtualItemInfoScNotify(SyncRogueVirtualItemInfoScNotify other) : this()
		{
			this.rogueVirtualItemInfo_ = ((other.rogueVirtualItemInfo_ != null) ? other.rogueVirtualItemInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4C7 RID: 54471 RVA: 0x00238248 File Offset: 0x00236448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueVirtualItemInfoScNotify Clone()
		{
			return new SyncRogueVirtualItemInfoScNotify(this);
		}

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x0600D4C8 RID: 54472 RVA: 0x00238250 File Offset: 0x00236450
		// (set) Token: 0x0600D4C9 RID: 54473 RVA: 0x00238258 File Offset: 0x00236458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueVirtualItemInfo RogueVirtualItemInfo
		{
			get
			{
				return this.rogueVirtualItemInfo_;
			}
			set
			{
				this.rogueVirtualItemInfo_ = value;
			}
		}

		// Token: 0x0600D4CA RID: 54474 RVA: 0x00238261 File Offset: 0x00236461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueVirtualItemInfoScNotify);
		}

		// Token: 0x0600D4CB RID: 54475 RVA: 0x0023826F File Offset: 0x0023646F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueVirtualItemInfoScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueVirtualItemInfo, other.RogueVirtualItemInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D4CC RID: 54476 RVA: 0x002382A4 File Offset: 0x002364A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueVirtualItemInfo_ != null)
			{
				num ^= this.RogueVirtualItemInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D4CD RID: 54477 RVA: 0x002382E0 File Offset: 0x002364E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D4CE RID: 54478 RVA: 0x002382E8 File Offset: 0x002364E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4CF RID: 54479 RVA: 0x002382F1 File Offset: 0x002364F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueVirtualItemInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RogueVirtualItemInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4D0 RID: 54480 RVA: 0x00238324 File Offset: 0x00236524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueVirtualItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueVirtualItemInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D4D1 RID: 54481 RVA: 0x00238364 File Offset: 0x00236564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueVirtualItemInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueVirtualItemInfo_ != null)
			{
				if (this.rogueVirtualItemInfo_ == null)
				{
					this.RogueVirtualItemInfo = new RogueVirtualItemInfo();
				}
				this.RogueVirtualItemInfo.MergeFrom(other.RogueVirtualItemInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4D2 RID: 54482 RVA: 0x002383B8 File Offset: 0x002365B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4D3 RID: 54483 RVA: 0x002383C4 File Offset: 0x002365C4
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
					if (this.rogueVirtualItemInfo_ == null)
					{
						this.RogueVirtualItemInfo = new RogueVirtualItemInfo();
					}
					input.ReadMessage(this.RogueVirtualItemInfo);
				}
			}
		}

		// Token: 0x0400551E RID: 21790
		private static readonly MessageParser<SyncRogueVirtualItemInfoScNotify> _parser = new MessageParser<SyncRogueVirtualItemInfoScNotify>(() => new SyncRogueVirtualItemInfoScNotify());

		// Token: 0x0400551F RID: 21791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005520 RID: 21792
		public const int RogueVirtualItemInfoFieldNumber = 14;

		// Token: 0x04005521 RID: 21793
		private RogueVirtualItemInfo rogueVirtualItemInfo_;
	}
}
