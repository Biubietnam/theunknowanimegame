using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000149 RID: 329
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BuyBpLevelScRsp : IMessage<BuyBpLevelScRsp>, IMessage, IEquatable<BuyBpLevelScRsp>, IDeepCloneable<BuyBpLevelScRsp>, IBufferMessage
	{
		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0002B7D8 File Offset: 0x000299D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuyBpLevelScRsp> Parser
		{
			get
			{
				return BuyBpLevelScRsp._parser;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0002B7DF File Offset: 0x000299DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BuyBpLevelScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0002B7F1 File Offset: 0x000299F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuyBpLevelScRsp.Descriptor;
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0002B7F8 File Offset: 0x000299F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyBpLevelScRsp()
		{
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0002B800 File Offset: 0x00029A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyBpLevelScRsp(BuyBpLevelScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0002B825 File Offset: 0x00029A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyBpLevelScRsp Clone()
		{
			return new BuyBpLevelScRsp(this);
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0002B82D File Offset: 0x00029A2D
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x0002B835 File Offset: 0x00029A35
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

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0002B83E File Offset: 0x00029A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuyBpLevelScRsp);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0002B84C File Offset: 0x00029A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuyBpLevelScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0002B87C File Offset: 0x00029A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0002B8BB File Offset: 0x00029ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0002B8C3 File Offset: 0x00029AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0002B8CC File Offset: 0x00029ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0002B900 File Offset: 0x00029B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0002B93E File Offset: 0x00029B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuyBpLevelScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0002B96F File Offset: 0x00029B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0002B978 File Offset: 0x00029B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400065B RID: 1627
		private static readonly MessageParser<BuyBpLevelScRsp> _parser = new MessageParser<BuyBpLevelScRsp>(() => new BuyBpLevelScRsp());

		// Token: 0x0400065C RID: 1628
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400065D RID: 1629
		public const int RetcodeFieldNumber = 2;

		// Token: 0x0400065E RID: 1630
		private uint retcode_;
	}
}
