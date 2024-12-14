using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F09 RID: 3849
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicScepterInfo : IMessage<RogueMagicScepterInfo>, IMessage, IEquatable<RogueMagicScepterInfo>, IDeepCloneable<RogueMagicScepterInfo>, IBufferMessage
	{
		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x0600ABD9 RID: 43993 RVA: 0x001CEC25 File Offset: 0x001CCE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicScepterInfo> Parser
		{
			get
			{
				return RogueMagicScepterInfo._parser;
			}
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x0600ABDA RID: 43994 RVA: 0x001CEC2C File Offset: 0x001CCE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x0600ABDB RID: 43995 RVA: 0x001CEC3E File Offset: 0x001CCE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicScepterInfo.Descriptor;
			}
		}

		// Token: 0x0600ABDC RID: 43996 RVA: 0x001CEC45 File Offset: 0x001CCE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterInfo()
		{
		}

		// Token: 0x0600ABDD RID: 43997 RVA: 0x001CEC4D File Offset: 0x001CCE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterInfo(RogueMagicScepterInfo other) : this()
		{
			this.magicItem_ = ((other.magicItem_ != null) ? other.magicItem_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABDE RID: 43998 RVA: 0x001CEC82 File Offset: 0x001CCE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterInfo Clone()
		{
			return new RogueMagicScepterInfo(this);
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x0600ABDF RID: 43999 RVA: 0x001CEC8A File Offset: 0x001CCE8A
		// (set) Token: 0x0600ABE0 RID: 44000 RVA: 0x001CEC92 File Offset: 0x001CCE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepter MagicItem
		{
			get
			{
				return this.magicItem_;
			}
			set
			{
				this.magicItem_ = value;
			}
		}

		// Token: 0x0600ABE1 RID: 44001 RVA: 0x001CEC9B File Offset: 0x001CCE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicScepterInfo);
		}

		// Token: 0x0600ABE2 RID: 44002 RVA: 0x001CECA9 File Offset: 0x001CCEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicScepterInfo other)
		{
			return other != null && (other == this || (object.Equals(this.MagicItem, other.MagicItem) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABE3 RID: 44003 RVA: 0x001CECDC File Offset: 0x001CCEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.magicItem_ != null)
			{
				num ^= this.MagicItem.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ABE4 RID: 44004 RVA: 0x001CED18 File Offset: 0x001CCF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x001CED20 File Offset: 0x001CCF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x001CED29 File Offset: 0x001CCF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.magicItem_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MagicItem);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABE7 RID: 44007 RVA: 0x001CED5C File Offset: 0x001CCF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.magicItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MagicItem);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ABE8 RID: 44008 RVA: 0x001CED9C File Offset: 0x001CCF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicScepterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.magicItem_ != null)
			{
				if (this.magicItem_ == null)
				{
					this.MagicItem = new RogueMagicScepter();
				}
				this.MagicItem.MergeFrom(other.MagicItem);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ABE9 RID: 44009 RVA: 0x001CEDF0 File Offset: 0x001CCFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABEA RID: 44010 RVA: 0x001CEDFC File Offset: 0x001CCFFC
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
					if (this.magicItem_ == null)
					{
						this.MagicItem = new RogueMagicScepter();
					}
					input.ReadMessage(this.MagicItem);
				}
			}
		}

		// Token: 0x0400461B RID: 17947
		private static readonly MessageParser<RogueMagicScepterInfo> _parser = new MessageParser<RogueMagicScepterInfo>(() => new RogueMagicScepterInfo());

		// Token: 0x0400461C RID: 17948
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400461D RID: 17949
		public const int MagicItemFieldNumber = 12;

		// Token: 0x0400461E RID: 17950
		private RogueMagicScepter magicItem_;
	}
}
