using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FC7 RID: 4039
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetArchiveRepositoryScRsp : IMessage<RogueTournGetArchiveRepositoryScRsp>, IMessage, IEquatable<RogueTournGetArchiveRepositoryScRsp>, IDeepCloneable<RogueTournGetArchiveRepositoryScRsp>, IBufferMessage
	{
		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600B3ED RID: 46061 RVA: 0x001E2FF7 File Offset: 0x001E11F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetArchiveRepositoryScRsp> Parser
		{
			get
			{
				return RogueTournGetArchiveRepositoryScRsp._parser;
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600B3EE RID: 46062 RVA: 0x001E2FFE File Offset: 0x001E11FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetArchiveRepositoryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600B3EF RID: 46063 RVA: 0x001E3010 File Offset: 0x001E1210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetArchiveRepositoryScRsp.Descriptor;
			}
		}

		// Token: 0x0600B3F0 RID: 46064 RVA: 0x001E3017 File Offset: 0x001E1217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetArchiveRepositoryScRsp()
		{
		}

		// Token: 0x0600B3F1 RID: 46065 RVA: 0x001E3038 File Offset: 0x001E1238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetArchiveRepositoryScRsp(RogueTournGetArchiveRepositoryScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.nJDJDLMCIBI_ = other.nJDJDLMCIBI_.Clone();
			this.hFKBDOKHKDH_ = other.hFKBDOKHKDH_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3F2 RID: 46066 RVA: 0x001E308A File Offset: 0x001E128A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetArchiveRepositoryScRsp Clone()
		{
			return new RogueTournGetArchiveRepositoryScRsp(this);
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600B3F3 RID: 46067 RVA: 0x001E3092 File Offset: 0x001E1292
		// (set) Token: 0x0600B3F4 RID: 46068 RVA: 0x001E309A File Offset: 0x001E129A
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

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600B3F5 RID: 46069 RVA: 0x001E30A3 File Offset: 0x001E12A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NJDJDLMCIBI
		{
			get
			{
				return this.nJDJDLMCIBI_;
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600B3F6 RID: 46070 RVA: 0x001E30AB File Offset: 0x001E12AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HFKBDOKHKDH
		{
			get
			{
				return this.hFKBDOKHKDH_;
			}
		}

		// Token: 0x0600B3F7 RID: 46071 RVA: 0x001E30B3 File Offset: 0x001E12B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetArchiveRepositoryScRsp);
		}

		// Token: 0x0600B3F8 RID: 46072 RVA: 0x001E30C4 File Offset: 0x001E12C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetArchiveRepositoryScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.nJDJDLMCIBI_.Equals(other.nJDJDLMCIBI_) && this.hFKBDOKHKDH_.Equals(other.hFKBDOKHKDH_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B3F9 RID: 46073 RVA: 0x001E3128 File Offset: 0x001E1328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.nJDJDLMCIBI_.GetHashCode();
			num ^= this.hFKBDOKHKDH_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B3FA RID: 46074 RVA: 0x001E3183 File Offset: 0x001E1383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B3FB RID: 46075 RVA: 0x001E318B File Offset: 0x001E138B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3FC RID: 46076 RVA: 0x001E3194 File Offset: 0x001E1394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			this.nJDJDLMCIBI_.WriteTo(ref output, RogueTournGetArchiveRepositoryScRsp._repeated_nJDJDLMCIBI_codec);
			this.hFKBDOKHKDH_.WriteTo(ref output, RogueTournGetArchiveRepositoryScRsp._repeated_hFKBDOKHKDH_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3FD RID: 46077 RVA: 0x001E31F4 File Offset: 0x001E13F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.nJDJDLMCIBI_.CalculateSize(RogueTournGetArchiveRepositoryScRsp._repeated_nJDJDLMCIBI_codec);
			num += this.hFKBDOKHKDH_.CalculateSize(RogueTournGetArchiveRepositoryScRsp._repeated_hFKBDOKHKDH_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3FE RID: 46078 RVA: 0x001E3258 File Offset: 0x001E1458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetArchiveRepositoryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.nJDJDLMCIBI_.Add(other.nJDJDLMCIBI_);
			this.hFKBDOKHKDH_.Add(other.hFKBDOKHKDH_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3FF RID: 46079 RVA: 0x001E32B6 File Offset: 0x001E14B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B400 RID: 46080 RVA: 0x001E32C0 File Offset: 0x001E14C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num == 32U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						goto IL_44;
					}
				}
				else
				{
					if (num == 90U)
					{
						goto IL_44;
					}
					if (num == 112U || num == 114U)
					{
						this.hFKBDOKHKDH_.AddEntriesFrom(ref input, RogueTournGetArchiveRepositoryScRsp._repeated_hFKBDOKHKDH_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_44:
				this.nJDJDLMCIBI_.AddEntriesFrom(ref input, RogueTournGetArchiveRepositoryScRsp._repeated_nJDJDLMCIBI_codec);
			}
		}

		// Token: 0x040048FA RID: 18682
		private static readonly MessageParser<RogueTournGetArchiveRepositoryScRsp> _parser = new MessageParser<RogueTournGetArchiveRepositoryScRsp>(() => new RogueTournGetArchiveRepositoryScRsp());

		// Token: 0x040048FB RID: 18683
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048FC RID: 18684
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040048FD RID: 18685
		private uint retcode_;

		// Token: 0x040048FE RID: 18686
		public const int NJDJDLMCIBIFieldNumber = 11;

		// Token: 0x040048FF RID: 18687
		private static readonly FieldCodec<uint> _repeated_nJDJDLMCIBI_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04004900 RID: 18688
		private readonly RepeatedField<uint> nJDJDLMCIBI_ = new RepeatedField<uint>();

		// Token: 0x04004901 RID: 18689
		public const int HFKBDOKHKDHFieldNumber = 14;

		// Token: 0x04004902 RID: 18690
		private static readonly FieldCodec<uint> _repeated_hFKBDOKHKDH_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04004903 RID: 18691
		private readonly RepeatedField<uint> hFKBDOKHKDH_ = new RepeatedField<uint>();
	}
}
