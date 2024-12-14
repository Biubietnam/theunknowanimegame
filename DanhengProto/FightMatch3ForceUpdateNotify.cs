using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200054B RID: 1355
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3ForceUpdateNotify : IMessage<FightMatch3ForceUpdateNotify>, IMessage, IEquatable<FightMatch3ForceUpdateNotify>, IDeepCloneable<FightMatch3ForceUpdateNotify>, IBufferMessage
	{
		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06003C60 RID: 15456 RVA: 0x000A57A5 File Offset: 0x000A39A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3ForceUpdateNotify> Parser
		{
			get
			{
				return FightMatch3ForceUpdateNotify._parser;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x000A57AC File Offset: 0x000A39AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3ForceUpdateNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06003C62 RID: 15458 RVA: 0x000A57BE File Offset: 0x000A39BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3ForceUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x000A57C5 File Offset: 0x000A39C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ForceUpdateNotify()
		{
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x000A57CD File Offset: 0x000A39CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ForceUpdateNotify(FightMatch3ForceUpdateNotify other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x000A5802 File Offset: 0x000A3A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ForceUpdateNotify Clone()
		{
			return new FightMatch3ForceUpdateNotify(this);
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06003C66 RID: 15462 RVA: 0x000A580A File Offset: 0x000A3A0A
		// (set) Token: 0x06003C67 RID: 15463 RVA: 0x000A5812 File Offset: 0x000A3A12
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

		// Token: 0x06003C68 RID: 15464 RVA: 0x000A581B File Offset: 0x000A3A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3ForceUpdateNotify);
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x000A5829 File Offset: 0x000A3A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3ForceUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x000A585C File Offset: 0x000A3A5C
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

		// Token: 0x06003C6B RID: 15467 RVA: 0x000A5898 File Offset: 0x000A3A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x000A58A0 File Offset: 0x000A3AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x000A58A9 File Offset: 0x000A3AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x000A58DC File Offset: 0x000A3ADC
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

		// Token: 0x06003C6F RID: 15471 RVA: 0x000A591C File Offset: 0x000A3B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3ForceUpdateNotify other)
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

		// Token: 0x06003C70 RID: 15472 RVA: 0x000A5970 File Offset: 0x000A3B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x000A597C File Offset: 0x000A3B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
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

		// Token: 0x0400183B RID: 6203
		private static readonly MessageParser<FightMatch3ForceUpdateNotify> _parser = new MessageParser<FightMatch3ForceUpdateNotify>(() => new FightMatch3ForceUpdateNotify());

		// Token: 0x0400183C RID: 6204
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400183D RID: 6205
		public const int DataFieldNumber = 12;

		// Token: 0x0400183E RID: 6206
		private CFHPMBOAHLA data_;
	}
}
