using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000705 RID: 1797
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMailCsReq : IMessage<GetMailCsReq>, IMessage, IEquatable<GetMailCsReq>, IDeepCloneable<GetMailCsReq>, IBufferMessage
	{
		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x0600504A RID: 20554 RVA: 0x000D8611 File Offset: 0x000D6811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMailCsReq> Parser
		{
			get
			{
				return GetMailCsReq._parser;
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x0600504B RID: 20555 RVA: 0x000D8618 File Offset: 0x000D6818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMailCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x0600504C RID: 20556 RVA: 0x000D862A File Offset: 0x000D682A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMailCsReq.Descriptor;
			}
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x000D8631 File Offset: 0x000D6831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMailCsReq()
		{
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x000D8639 File Offset: 0x000D6839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMailCsReq(GetMailCsReq other) : this()
		{
			this.mUSEUMRANDOMEVENTSTATESTART_ = other.mUSEUMRANDOMEVENTSTATESTART_;
			this.mMGNPGKOECO_ = other.mMGNPGKOECO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x000D866A File Offset: 0x000D686A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMailCsReq Clone()
		{
			return new GetMailCsReq(this);
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06005050 RID: 20560 RVA: 0x000D8672 File Offset: 0x000D6872
		// (set) Token: 0x06005051 RID: 20561 RVA: 0x000D867A File Offset: 0x000D687A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MUSEUMRANDOMEVENTSTATESTART
		{
			get
			{
				return this.mUSEUMRANDOMEVENTSTATESTART_;
			}
			set
			{
				this.mUSEUMRANDOMEVENTSTATESTART_ = value;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06005052 RID: 20562 RVA: 0x000D8683 File Offset: 0x000D6883
		// (set) Token: 0x06005053 RID: 20563 RVA: 0x000D868B File Offset: 0x000D688B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMGNPGKOECO
		{
			get
			{
				return this.mMGNPGKOECO_;
			}
			set
			{
				this.mMGNPGKOECO_ = value;
			}
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x000D8694 File Offset: 0x000D6894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMailCsReq);
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x000D86A2 File Offset: 0x000D68A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMailCsReq other)
		{
			return other != null && (other == this || (this.MUSEUMRANDOMEVENTSTATESTART == other.MUSEUMRANDOMEVENTSTATESTART && this.MMGNPGKOECO == other.MMGNPGKOECO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x000D86E0 File Offset: 0x000D68E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MUSEUMRANDOMEVENTSTATESTART != 0U)
			{
				num ^= this.MUSEUMRANDOMEVENTSTATESTART.GetHashCode();
			}
			if (this.MMGNPGKOECO != 0U)
			{
				num ^= this.MMGNPGKOECO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x000D8738 File Offset: 0x000D6938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x000D8740 File Offset: 0x000D6940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x000D874C File Offset: 0x000D694C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MUSEUMRANDOMEVENTSTATESTART != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MUSEUMRANDOMEVENTSTATESTART);
			}
			if (this.MMGNPGKOECO != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MMGNPGKOECO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x000D87A4 File Offset: 0x000D69A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MUSEUMRANDOMEVENTSTATESTART != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MUSEUMRANDOMEVENTSTATESTART);
			}
			if (this.MMGNPGKOECO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMGNPGKOECO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x000D87FC File Offset: 0x000D69FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMailCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MUSEUMRANDOMEVENTSTATESTART != 0U)
			{
				this.MUSEUMRANDOMEVENTSTATESTART = other.MUSEUMRANDOMEVENTSTATESTART;
			}
			if (other.MMGNPGKOECO != 0U)
			{
				this.MMGNPGKOECO = other.MMGNPGKOECO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x000D884C File Offset: 0x000D6A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x000D8858 File Offset: 0x000D6A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MMGNPGKOECO = input.ReadUInt32();
					}
				}
				else
				{
					this.MUSEUMRANDOMEVENTSTATESTART = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001F90 RID: 8080
		private static readonly MessageParser<GetMailCsReq> _parser = new MessageParser<GetMailCsReq>(() => new GetMailCsReq());

		// Token: 0x04001F91 RID: 8081
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F92 RID: 8082
		public const int MUSEUMRANDOMEVENTSTATESTARTFieldNumber = 1;

		// Token: 0x04001F93 RID: 8083
		private uint mUSEUMRANDOMEVENTSTATESTART_;

		// Token: 0x04001F94 RID: 8084
		public const int MMGNPGKOECOFieldNumber = 6;

		// Token: 0x04001F95 RID: 8085
		private uint mMGNPGKOECO_;
	}
}
