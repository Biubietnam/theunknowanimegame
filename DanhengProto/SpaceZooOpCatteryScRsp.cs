using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001171 RID: 4465
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooOpCatteryScRsp : IMessage<SpaceZooOpCatteryScRsp>, IMessage, IEquatable<SpaceZooOpCatteryScRsp>, IDeepCloneable<SpaceZooOpCatteryScRsp>, IBufferMessage
	{
		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0600C738 RID: 51000 RVA: 0x00216B18 File Offset: 0x00214D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooOpCatteryScRsp> Parser
		{
			get
			{
				return SpaceZooOpCatteryScRsp._parser;
			}
		}

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x0600C739 RID: 51001 RVA: 0x00216B1F File Offset: 0x00214D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooOpCatteryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0600C73A RID: 51002 RVA: 0x00216B31 File Offset: 0x00214D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooOpCatteryScRsp.Descriptor;
			}
		}

		// Token: 0x0600C73B RID: 51003 RVA: 0x00216B38 File Offset: 0x00214D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooOpCatteryScRsp()
		{
		}

		// Token: 0x0600C73C RID: 51004 RVA: 0x00216B4B File Offset: 0x00214D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooOpCatteryScRsp(SpaceZooOpCatteryScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.pNKEOHGMJIE_ = other.pNKEOHGMJIE_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C73D RID: 51005 RVA: 0x00216B81 File Offset: 0x00214D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooOpCatteryScRsp Clone()
		{
			return new SpaceZooOpCatteryScRsp(this);
		}

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0600C73E RID: 51006 RVA: 0x00216B89 File Offset: 0x00214D89
		// (set) Token: 0x0600C73F RID: 51007 RVA: 0x00216B91 File Offset: 0x00214D91
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

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0600C740 RID: 51008 RVA: 0x00216B9A File Offset: 0x00214D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PNKEOHGMJIE
		{
			get
			{
				return this.pNKEOHGMJIE_;
			}
		}

		// Token: 0x0600C741 RID: 51009 RVA: 0x00216BA2 File Offset: 0x00214DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooOpCatteryScRsp);
		}

		// Token: 0x0600C742 RID: 51010 RVA: 0x00216BB0 File Offset: 0x00214DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooOpCatteryScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.pNKEOHGMJIE_.Equals(other.pNKEOHGMJIE_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C743 RID: 51011 RVA: 0x00216C00 File Offset: 0x00214E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.pNKEOHGMJIE_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C744 RID: 51012 RVA: 0x00216C4D File Offset: 0x00214E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C745 RID: 51013 RVA: 0x00216C55 File Offset: 0x00214E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C746 RID: 51014 RVA: 0x00216C60 File Offset: 0x00214E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pNKEOHGMJIE_.WriteTo(ref output, SpaceZooOpCatteryScRsp._repeated_pNKEOHGMJIE_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C747 RID: 51015 RVA: 0x00216CB0 File Offset: 0x00214EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.pNKEOHGMJIE_.CalculateSize(SpaceZooOpCatteryScRsp._repeated_pNKEOHGMJIE_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C748 RID: 51016 RVA: 0x00216D04 File Offset: 0x00214F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooOpCatteryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.pNKEOHGMJIE_.Add(other.pNKEOHGMJIE_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C749 RID: 51017 RVA: 0x00216D51 File Offset: 0x00214F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C74A RID: 51018 RVA: 0x00216D5C File Offset: 0x00214F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U && num != 66U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.pNKEOHGMJIE_.AddEntriesFrom(ref input, SpaceZooOpCatteryScRsp._repeated_pNKEOHGMJIE_codec);
				}
			}
		}

		// Token: 0x0400507C RID: 20604
		private static readonly MessageParser<SpaceZooOpCatteryScRsp> _parser = new MessageParser<SpaceZooOpCatteryScRsp>(() => new SpaceZooOpCatteryScRsp());

		// Token: 0x0400507D RID: 20605
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400507E RID: 20606
		public const int RetcodeFieldNumber = 9;

		// Token: 0x0400507F RID: 20607
		private uint retcode_;

		// Token: 0x04005080 RID: 20608
		public const int PNKEOHGMJIEFieldNumber = 8;

		// Token: 0x04005081 RID: 20609
		private static readonly FieldCodec<uint> _repeated_pNKEOHGMJIE_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04005082 RID: 20610
		private readonly RepeatedField<uint> pNKEOHGMJIE_ = new RepeatedField<uint>();
	}
}
