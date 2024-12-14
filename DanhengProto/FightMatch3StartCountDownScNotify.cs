using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200054F RID: 1359
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3StartCountDownScNotify : IMessage<FightMatch3StartCountDownScNotify>, IMessage, IEquatable<FightMatch3StartCountDownScNotify>, IDeepCloneable<FightMatch3StartCountDownScNotify>, IBufferMessage
	{
		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06003C92 RID: 15506 RVA: 0x000A5FF1 File Offset: 0x000A41F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3StartCountDownScNotify> Parser
		{
			get
			{
				return FightMatch3StartCountDownScNotify._parser;
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06003C93 RID: 15507 RVA: 0x000A5FF8 File Offset: 0x000A41F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3StartCountDownScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06003C94 RID: 15508 RVA: 0x000A600A File Offset: 0x000A420A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3StartCountDownScNotify.Descriptor;
			}
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x000A6011 File Offset: 0x000A4211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3StartCountDownScNotify()
		{
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x000A6019 File Offset: 0x000A4219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3StartCountDownScNotify(FightMatch3StartCountDownScNotify other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x000A604E File Offset: 0x000A424E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3StartCountDownScNotify Clone()
		{
			return new FightMatch3StartCountDownScNotify(this);
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06003C98 RID: 15512 RVA: 0x000A6056 File Offset: 0x000A4256
		// (set) Token: 0x06003C99 RID: 15513 RVA: 0x000A605E File Offset: 0x000A425E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFHPMBOAHLA Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x000A6067 File Offset: 0x000A4267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3StartCountDownScNotify);
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x000A6075 File Offset: 0x000A4275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3StartCountDownScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x000A60A8 File Offset: 0x000A42A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x000A60E4 File Offset: 0x000A42E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x000A60EC File Offset: 0x000A42EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x000A60F5 File Offset: 0x000A42F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x000A6128 File Offset: 0x000A4328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x000A6168 File Offset: 0x000A4368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3StartCountDownScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new CFHPMBOAHLA();
				}
				this.Data.MergeFrom(other.Data);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x000A61BC File Offset: 0x000A43BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x000A61C8 File Offset: 0x000A43C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.data_ == null)
					{
						this.Data = new CFHPMBOAHLA();
					}
					input.ReadMessage(this.Data);
				}
			}
		}

		// Token: 0x0400184D RID: 6221
		private static readonly MessageParser<FightMatch3StartCountDownScNotify> _parser = new MessageParser<FightMatch3StartCountDownScNotify>(() => new FightMatch3StartCountDownScNotify());

		// Token: 0x0400184E RID: 6222
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400184F RID: 6223
		public const int DataFieldNumber = 3;

		// Token: 0x04001850 RID: 6224
		private CFHPMBOAHLA data_;
	}
}
