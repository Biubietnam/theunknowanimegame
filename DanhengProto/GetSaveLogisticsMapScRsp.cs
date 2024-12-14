using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007DF RID: 2015
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSaveLogisticsMapScRsp : IMessage<GetSaveLogisticsMapScRsp>, IMessage, IEquatable<GetSaveLogisticsMapScRsp>, IDeepCloneable<GetSaveLogisticsMapScRsp>, IBufferMessage
	{
		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x060059DB RID: 23003 RVA: 0x000EF9DD File Offset: 0x000EDBDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSaveLogisticsMapScRsp> Parser
		{
			get
			{
				return GetSaveLogisticsMapScRsp._parser;
			}
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x060059DC RID: 23004 RVA: 0x000EF9E4 File Offset: 0x000EDBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSaveLogisticsMapScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x060059DD RID: 23005 RVA: 0x000EF9F6 File Offset: 0x000EDBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSaveLogisticsMapScRsp.Descriptor;
			}
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x000EF9FD File Offset: 0x000EDBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveLogisticsMapScRsp()
		{
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x000EFA10 File Offset: 0x000EDC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveLogisticsMapScRsp(GetSaveLogisticsMapScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.hJFIDJAHMJG_ = other.hJFIDJAHMJG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x000EFA46 File Offset: 0x000EDC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveLogisticsMapScRsp Clone()
		{
			return new GetSaveLogisticsMapScRsp(this);
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x060059E1 RID: 23009 RVA: 0x000EFA4E File Offset: 0x000EDC4E
		// (set) Token: 0x060059E2 RID: 23010 RVA: 0x000EFA56 File Offset: 0x000EDC56
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

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x060059E3 RID: 23011 RVA: 0x000EFA5F File Offset: 0x000EDC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HGGCNNJOEPH> HJFIDJAHMJG
		{
			get
			{
				return this.hJFIDJAHMJG_;
			}
		}

		// Token: 0x060059E4 RID: 23012 RVA: 0x000EFA67 File Offset: 0x000EDC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSaveLogisticsMapScRsp);
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x000EFA78 File Offset: 0x000EDC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSaveLogisticsMapScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.hJFIDJAHMJG_.Equals(other.hJFIDJAHMJG_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x000EFAC8 File Offset: 0x000EDCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.hJFIDJAHMJG_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x000EFB15 File Offset: 0x000EDD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x000EFB1D File Offset: 0x000EDD1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x000EFB28 File Offset: 0x000EDD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			this.hJFIDJAHMJG_.WriteTo(ref output, GetSaveLogisticsMapScRsp._repeated_hJFIDJAHMJG_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059EA RID: 23018 RVA: 0x000EFB78 File Offset: 0x000EDD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.hJFIDJAHMJG_.CalculateSize(GetSaveLogisticsMapScRsp._repeated_hJFIDJAHMJG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059EB RID: 23019 RVA: 0x000EFBCC File Offset: 0x000EDDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSaveLogisticsMapScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.hJFIDJAHMJG_.Add(other.hJFIDJAHMJG_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060059EC RID: 23020 RVA: 0x000EFC19 File Offset: 0x000EDE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059ED RID: 23021 RVA: 0x000EFC24 File Offset: 0x000EDE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.hJFIDJAHMJG_.AddEntriesFrom(ref input, GetSaveLogisticsMapScRsp._repeated_hJFIDJAHMJG_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040022E1 RID: 8929
		private static readonly MessageParser<GetSaveLogisticsMapScRsp> _parser = new MessageParser<GetSaveLogisticsMapScRsp>(() => new GetSaveLogisticsMapScRsp());

		// Token: 0x040022E2 RID: 8930
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022E3 RID: 8931
		public const int RetcodeFieldNumber = 7;

		// Token: 0x040022E4 RID: 8932
		private uint retcode_;

		// Token: 0x040022E5 RID: 8933
		public const int HJFIDJAHMJGFieldNumber = 9;

		// Token: 0x040022E6 RID: 8934
		private static readonly FieldCodec<HGGCNNJOEPH> _repeated_hJFIDJAHMJG_codec = FieldCodec.ForMessage<HGGCNNJOEPH>(74U, HGGCNNJOEPH.Parser);

		// Token: 0x040022E7 RID: 8935
		private readonly RepeatedField<HGGCNNJOEPH> hJFIDJAHMJG_ = new RepeatedField<HGGCNNJOEPH>();
	}
}
