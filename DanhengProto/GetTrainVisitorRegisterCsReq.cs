using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200082D RID: 2093
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTrainVisitorRegisterCsReq : IMessage<GetTrainVisitorRegisterCsReq>, IMessage, IEquatable<GetTrainVisitorRegisterCsReq>, IDeepCloneable<GetTrainVisitorRegisterCsReq>, IBufferMessage
	{
		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06005D29 RID: 23849 RVA: 0x000F74ED File Offset: 0x000F56ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTrainVisitorRegisterCsReq> Parser
		{
			get
			{
				return GetTrainVisitorRegisterCsReq._parser;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06005D2A RID: 23850 RVA: 0x000F74F4 File Offset: 0x000F56F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTrainVisitorRegisterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06005D2B RID: 23851 RVA: 0x000F7506 File Offset: 0x000F5706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTrainVisitorRegisterCsReq.Descriptor;
			}
		}

		// Token: 0x06005D2C RID: 23852 RVA: 0x000F750D File Offset: 0x000F570D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorRegisterCsReq()
		{
		}

		// Token: 0x06005D2D RID: 23853 RVA: 0x000F7515 File Offset: 0x000F5715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorRegisterCsReq(GetTrainVisitorRegisterCsReq other) : this()
		{
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x000F753A File Offset: 0x000F573A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorRegisterCsReq Clone()
		{
			return new GetTrainVisitorRegisterCsReq(this);
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x06005D2F RID: 23855 RVA: 0x000F7542 File Offset: 0x000F5742
		// (set) Token: 0x06005D30 RID: 23856 RVA: 0x000F754A File Offset: 0x000F574A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GKGIEBBBNLI Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06005D31 RID: 23857 RVA: 0x000F7553 File Offset: 0x000F5753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTrainVisitorRegisterCsReq);
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x000F7561 File Offset: 0x000F5761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTrainVisitorRegisterCsReq other)
		{
			return other != null && (other == this || (this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x000F7590 File Offset: 0x000F5790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != GKGIEBBBNLI.TrainVisitorRegisterGetTypeNone)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x000F75D5 File Offset: 0x000F57D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x000F75DD File Offset: 0x000F57DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D36 RID: 23862 RVA: 0x000F75E6 File Offset: 0x000F57E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != GKGIEBBBNLI.TrainVisitorRegisterGetTypeNone)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D37 RID: 23863 RVA: 0x000F7618 File Offset: 0x000F5818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != GKGIEBBBNLI.TrainVisitorRegisterGetTypeNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D38 RID: 23864 RVA: 0x000F7656 File Offset: 0x000F5856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTrainVisitorRegisterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != GKGIEBBBNLI.TrainVisitorRegisterGetTypeNone)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D39 RID: 23865 RVA: 0x000F7687 File Offset: 0x000F5887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D3A RID: 23866 RVA: 0x000F7690 File Offset: 0x000F5890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Type = (GKGIEBBBNLI)input.ReadEnum();
				}
			}
		}

		// Token: 0x040023FE RID: 9214
		private static readonly MessageParser<GetTrainVisitorRegisterCsReq> _parser = new MessageParser<GetTrainVisitorRegisterCsReq>(() => new GetTrainVisitorRegisterCsReq());

		// Token: 0x040023FF RID: 9215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002400 RID: 9216
		public const int TypeFieldNumber = 9;

		// Token: 0x04002401 RID: 9217
		private GKGIEBBBNLI type_;
	}
}
