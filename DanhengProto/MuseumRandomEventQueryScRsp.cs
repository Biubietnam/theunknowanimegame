using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BC3 RID: 3011
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumRandomEventQueryScRsp : IMessage<MuseumRandomEventQueryScRsp>, IMessage, IEquatable<MuseumRandomEventQueryScRsp>, IDeepCloneable<MuseumRandomEventQueryScRsp>, IBufferMessage
	{
		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x0600854A RID: 34122 RVA: 0x00160025 File Offset: 0x0015E225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumRandomEventQueryScRsp> Parser
		{
			get
			{
				return MuseumRandomEventQueryScRsp._parser;
			}
		}

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x0600854B RID: 34123 RVA: 0x0016002C File Offset: 0x0015E22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumRandomEventQueryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x0600854C RID: 34124 RVA: 0x0016003E File Offset: 0x0015E23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumRandomEventQueryScRsp.Descriptor;
			}
		}

		// Token: 0x0600854D RID: 34125 RVA: 0x00160045 File Offset: 0x0015E245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventQueryScRsp()
		{
		}

		// Token: 0x0600854E RID: 34126 RVA: 0x00160050 File Offset: 0x0015E250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventQueryScRsp(MuseumRandomEventQueryScRsp other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600854F RID: 34127 RVA: 0x0016009C File Offset: 0x0015E29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventQueryScRsp Clone()
		{
			return new MuseumRandomEventQueryScRsp(this);
		}

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x06008550 RID: 34128 RVA: 0x001600A4 File Offset: 0x0015E2A4
		// (set) Token: 0x06008551 RID: 34129 RVA: 0x001600AC File Offset: 0x0015E2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FMDGFCNOKMN Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x06008552 RID: 34130 RVA: 0x001600B5 File Offset: 0x0015E2B5
		// (set) Token: 0x06008553 RID: 34131 RVA: 0x001600BD File Offset: 0x0015E2BD
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

		// Token: 0x06008554 RID: 34132 RVA: 0x001600C6 File Offset: 0x0015E2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumRandomEventQueryScRsp);
		}

		// Token: 0x06008555 RID: 34133 RVA: 0x001600D4 File Offset: 0x0015E2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumRandomEventQueryScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008556 RID: 34134 RVA: 0x00160124 File Offset: 0x0015E324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
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

		// Token: 0x06008557 RID: 34135 RVA: 0x00160179 File Offset: 0x0015E379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008558 RID: 34136 RVA: 0x00160181 File Offset: 0x0015E381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008559 RID: 34137 RVA: 0x0016018C File Offset: 0x0015E38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Info);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x001601E8 File Offset: 0x0015E3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
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

		// Token: 0x0600855B RID: 34139 RVA: 0x00160240 File Offset: 0x0015E440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumRandomEventQueryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new FMDGFCNOKMN();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x001602A8 File Offset: 0x0015E4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600855D RID: 34141 RVA: 0x001602B4 File Offset: 0x0015E4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 112U)
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
					if (this.info_ == null)
					{
						this.Info = new FMDGFCNOKMN();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04003313 RID: 13075
		private static readonly MessageParser<MuseumRandomEventQueryScRsp> _parser = new MessageParser<MuseumRandomEventQueryScRsp>(() => new MuseumRandomEventQueryScRsp());

		// Token: 0x04003314 RID: 13076
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003315 RID: 13077
		public const int InfoFieldNumber = 4;

		// Token: 0x04003316 RID: 13078
		private FMDGFCNOKMN info_;

		// Token: 0x04003317 RID: 13079
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04003318 RID: 13080
		private uint retcode_;
	}
}
