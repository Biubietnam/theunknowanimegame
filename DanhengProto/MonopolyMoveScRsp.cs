using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B63 RID: 2915
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyMoveScRsp : IMessage<MonopolyMoveScRsp>, IMessage, IEquatable<MonopolyMoveScRsp>, IDeepCloneable<MonopolyMoveScRsp>, IBufferMessage
	{
		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x060080FF RID: 33023 RVA: 0x00154193 File Offset: 0x00152393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyMoveScRsp> Parser
		{
			get
			{
				return MonopolyMoveScRsp._parser;
			}
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x06008100 RID: 33024 RVA: 0x0015419A File Offset: 0x0015239A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyMoveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x06008101 RID: 33025 RVA: 0x001541AC File Offset: 0x001523AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyMoveScRsp.Descriptor;
			}
		}

		// Token: 0x06008102 RID: 33026 RVA: 0x001541B3 File Offset: 0x001523B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyMoveScRsp()
		{
		}

		// Token: 0x06008103 RID: 33027 RVA: 0x001541C8 File Offset: 0x001523C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyMoveScRsp(MonopolyMoveScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.roomMap_ = ((other.roomMap_ != null) ? other.roomMap_.Clone() : null);
			this.lIAJEHOIANG_ = other.lIAJEHOIANG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008104 RID: 33028 RVA: 0x00154225 File Offset: 0x00152425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyMoveScRsp Clone()
		{
			return new MonopolyMoveScRsp(this);
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x06008105 RID: 33029 RVA: 0x0015422D File Offset: 0x0015242D
		// (set) Token: 0x06008106 RID: 33030 RVA: 0x00154235 File Offset: 0x00152435
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

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x06008107 RID: 33031 RVA: 0x0015423E File Offset: 0x0015243E
		// (set) Token: 0x06008108 RID: 33032 RVA: 0x00154246 File Offset: 0x00152446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMICCBDOCGG RoomMap
		{
			get
			{
				return this.roomMap_;
			}
			set
			{
				this.roomMap_ = value;
			}
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x06008109 RID: 33033 RVA: 0x0015424F File Offset: 0x0015244F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DHAIJMPAJDL> LIAJEHOIANG
		{
			get
			{
				return this.lIAJEHOIANG_;
			}
		}

		// Token: 0x0600810A RID: 33034 RVA: 0x00154257 File Offset: 0x00152457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyMoveScRsp);
		}

		// Token: 0x0600810B RID: 33035 RVA: 0x00154268 File Offset: 0x00152468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyMoveScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RoomMap, other.RoomMap) && this.lIAJEHOIANG_.Equals(other.lIAJEHOIANG_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600810C RID: 33036 RVA: 0x001542CC File Offset: 0x001524CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.roomMap_ != null)
			{
				num ^= this.RoomMap.GetHashCode();
			}
			num ^= this.lIAJEHOIANG_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x0015432F File Offset: 0x0015252F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x00154337 File Offset: 0x00152537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600810F RID: 33039 RVA: 0x00154340 File Offset: 0x00152540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lIAJEHOIANG_.WriteTo(ref output, MonopolyMoveScRsp._repeated_lIAJEHOIANG_codec);
			if (this.roomMap_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RoomMap);
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

		// Token: 0x06008110 RID: 33040 RVA: 0x001543AC File Offset: 0x001525AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.roomMap_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoomMap);
			}
			num += this.lIAJEHOIANG_.CalculateSize(MonopolyMoveScRsp._repeated_lIAJEHOIANG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008111 RID: 33041 RVA: 0x00154418 File Offset: 0x00152618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyMoveScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.roomMap_ != null)
			{
				if (this.roomMap_ == null)
				{
					this.RoomMap = new BMICCBDOCGG();
				}
				this.RoomMap.MergeFrom(other.RoomMap);
			}
			this.lIAJEHOIANG_.Add(other.lIAJEHOIANG_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x00154491 File Offset: 0x00152691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008113 RID: 33043 RVA: 0x0015449C File Offset: 0x0015269C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 82U)
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
						if (this.roomMap_ == null)
						{
							this.RoomMap = new BMICCBDOCGG();
						}
						input.ReadMessage(this.RoomMap);
					}
				}
				else
				{
					this.lIAJEHOIANG_.AddEntriesFrom(ref input, MonopolyMoveScRsp._repeated_lIAJEHOIANG_codec);
				}
			}
		}

		// Token: 0x04003144 RID: 12612
		private static readonly MessageParser<MonopolyMoveScRsp> _parser = new MessageParser<MonopolyMoveScRsp>(() => new MonopolyMoveScRsp());

		// Token: 0x04003145 RID: 12613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003146 RID: 12614
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04003147 RID: 12615
		private uint retcode_;

		// Token: 0x04003148 RID: 12616
		public const int RoomMapFieldNumber = 10;

		// Token: 0x04003149 RID: 12617
		private BMICCBDOCGG roomMap_;

		// Token: 0x0400314A RID: 12618
		public const int LIAJEHOIANGFieldNumber = 3;

		// Token: 0x0400314B RID: 12619
		private static readonly FieldCodec<DHAIJMPAJDL> _repeated_lIAJEHOIANG_codec = FieldCodec.ForMessage<DHAIJMPAJDL>(26U, DHAIJMPAJDL.Parser);

		// Token: 0x0400314C RID: 12620
		private readonly RepeatedField<DHAIJMPAJDL> lIAJEHOIANG_ = new RepeatedField<DHAIJMPAJDL>();
	}
}
