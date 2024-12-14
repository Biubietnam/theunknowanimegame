using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006D5 RID: 1749
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetGachaCeilingCsReq : IMessage<GetGachaCeilingCsReq>, IMessage, IEquatable<GetGachaCeilingCsReq>, IDeepCloneable<GetGachaCeilingCsReq>, IBufferMessage
	{
		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06004E41 RID: 20033 RVA: 0x000D3CE8 File Offset: 0x000D1EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetGachaCeilingCsReq> Parser
		{
			get
			{
				return GetGachaCeilingCsReq._parser;
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x000D3CEF File Offset: 0x000D1EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetGachaCeilingCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06004E43 RID: 20035 RVA: 0x000D3D01 File Offset: 0x000D1F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGachaCeilingCsReq.Descriptor;
			}
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x000D3D08 File Offset: 0x000D1F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaCeilingCsReq()
		{
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x000D3D10 File Offset: 0x000D1F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaCeilingCsReq(GetGachaCeilingCsReq other) : this()
		{
			this.gachaType_ = other.gachaType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x000D3D35 File Offset: 0x000D1F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaCeilingCsReq Clone()
		{
			return new GetGachaCeilingCsReq(this);
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06004E47 RID: 20039 RVA: 0x000D3D3D File Offset: 0x000D1F3D
		// (set) Token: 0x06004E48 RID: 20040 RVA: 0x000D3D45 File Offset: 0x000D1F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaType
		{
			get
			{
				return this.gachaType_;
			}
			set
			{
				this.gachaType_ = value;
			}
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x000D3D4E File Offset: 0x000D1F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGachaCeilingCsReq);
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x000D3D5C File Offset: 0x000D1F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetGachaCeilingCsReq other)
		{
			return other != null && (other == this || (this.GachaType == other.GachaType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x000D3D8C File Offset: 0x000D1F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaType != 0U)
			{
				num ^= this.GachaType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x000D3DCB File Offset: 0x000D1FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x000D3DD3 File Offset: 0x000D1FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x000D3DDC File Offset: 0x000D1FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaType != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.GachaType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x000D3E10 File Offset: 0x000D2010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x000D3E4E File Offset: 0x000D204E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetGachaCeilingCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaType != 0U)
			{
				this.GachaType = other.GachaType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x000D3E7F File Offset: 0x000D207F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x000D3E88 File Offset: 0x000D2088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GachaType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001EE9 RID: 7913
		private static readonly MessageParser<GetGachaCeilingCsReq> _parser = new MessageParser<GetGachaCeilingCsReq>(() => new GetGachaCeilingCsReq());

		// Token: 0x04001EEA RID: 7914
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EEB RID: 7915
		public const int GachaTypeFieldNumber = 10;

		// Token: 0x04001EEC RID: 7916
		private uint gachaType_;
	}
}
