using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FC3 RID: 4035
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetAllArchiveScRsp : IMessage<RogueTournGetAllArchiveScRsp>, IMessage, IEquatable<RogueTournGetAllArchiveScRsp>, IDeepCloneable<RogueTournGetAllArchiveScRsp>, IBufferMessage
	{
		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600B3C4 RID: 46020 RVA: 0x001E2AD7 File Offset: 0x001E0CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetAllArchiveScRsp> Parser
		{
			get
			{
				return RogueTournGetAllArchiveScRsp._parser;
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600B3C5 RID: 46021 RVA: 0x001E2ADE File Offset: 0x001E0CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetAllArchiveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600B3C6 RID: 46022 RVA: 0x001E2AF0 File Offset: 0x001E0CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetAllArchiveScRsp.Descriptor;
			}
		}

		// Token: 0x0600B3C7 RID: 46023 RVA: 0x001E2AF7 File Offset: 0x001E0CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetAllArchiveScRsp()
		{
		}

		// Token: 0x0600B3C8 RID: 46024 RVA: 0x001E2B0A File Offset: 0x001E0D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetAllArchiveScRsp(RogueTournGetAllArchiveScRsp other) : this()
		{
			this.aMFDAPBMDAM_ = other.aMFDAPBMDAM_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3C9 RID: 46025 RVA: 0x001E2B40 File Offset: 0x001E0D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetAllArchiveScRsp Clone()
		{
			return new RogueTournGetAllArchiveScRsp(this);
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600B3CA RID: 46026 RVA: 0x001E2B48 File Offset: 0x001E0D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueTournSaveList> AMFDAPBMDAM
		{
			get
			{
				return this.aMFDAPBMDAM_;
			}
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0600B3CB RID: 46027 RVA: 0x001E2B50 File Offset: 0x001E0D50
		// (set) Token: 0x0600B3CC RID: 46028 RVA: 0x001E2B58 File Offset: 0x001E0D58
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

		// Token: 0x0600B3CD RID: 46029 RVA: 0x001E2B61 File Offset: 0x001E0D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetAllArchiveScRsp);
		}

		// Token: 0x0600B3CE RID: 46030 RVA: 0x001E2B70 File Offset: 0x001E0D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetAllArchiveScRsp other)
		{
			return other != null && (other == this || (this.aMFDAPBMDAM_.Equals(other.aMFDAPBMDAM_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B3CF RID: 46031 RVA: 0x001E2BC0 File Offset: 0x001E0DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aMFDAPBMDAM_.GetHashCode();
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

		// Token: 0x0600B3D0 RID: 46032 RVA: 0x001E2C0D File Offset: 0x001E0E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B3D1 RID: 46033 RVA: 0x001E2C15 File Offset: 0x001E0E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x001E2C20 File Offset: 0x001E0E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aMFDAPBMDAM_.WriteTo(ref output, RogueTournGetAllArchiveScRsp._repeated_aMFDAPBMDAM_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x001E2C70 File Offset: 0x001E0E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aMFDAPBMDAM_.CalculateSize(RogueTournGetAllArchiveScRsp._repeated_aMFDAPBMDAM_codec);
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

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x001E2CC4 File Offset: 0x001E0EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetAllArchiveScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.aMFDAPBMDAM_.Add(other.aMFDAPBMDAM_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3D5 RID: 46037 RVA: 0x001E2D11 File Offset: 0x001E0F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x001E2D1C File Offset: 0x001E0F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 104U)
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
					this.aMFDAPBMDAM_.AddEntriesFrom(ref input, RogueTournGetAllArchiveScRsp._repeated_aMFDAPBMDAM_codec);
				}
			}
		}

		// Token: 0x040048EF RID: 18671
		private static readonly MessageParser<RogueTournGetAllArchiveScRsp> _parser = new MessageParser<RogueTournGetAllArchiveScRsp>(() => new RogueTournGetAllArchiveScRsp());

		// Token: 0x040048F0 RID: 18672
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048F1 RID: 18673
		public const int AMFDAPBMDAMFieldNumber = 1;

		// Token: 0x040048F2 RID: 18674
		private static readonly FieldCodec<RogueTournSaveList> _repeated_aMFDAPBMDAM_codec = FieldCodec.ForMessage<RogueTournSaveList>(10U, RogueTournSaveList.Parser);

		// Token: 0x040048F3 RID: 18675
		private readonly RepeatedField<RogueTournSaveList> aMFDAPBMDAM_ = new RepeatedField<RogueTournSaveList>();

		// Token: 0x040048F4 RID: 18676
		public const int RetcodeFieldNumber = 13;

		// Token: 0x040048F5 RID: 18677
		private uint retcode_;
	}
}
