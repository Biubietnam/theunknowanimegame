using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000791 RID: 1937
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRecyleTimeCsReq : IMessage<GetRecyleTimeCsReq>, IMessage, IEquatable<GetRecyleTimeCsReq>, IDeepCloneable<GetRecyleTimeCsReq>, IBufferMessage
	{
		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06005681 RID: 22145 RVA: 0x000E8050 File Offset: 0x000E6250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRecyleTimeCsReq> Parser
		{
			get
			{
				return GetRecyleTimeCsReq._parser;
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06005682 RID: 22146 RVA: 0x000E8057 File Offset: 0x000E6257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRecyleTimeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06005683 RID: 22147 RVA: 0x000E8069 File Offset: 0x000E6269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRecyleTimeCsReq.Descriptor;
			}
		}

		// Token: 0x06005684 RID: 22148 RVA: 0x000E8070 File Offset: 0x000E6270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRecyleTimeCsReq()
		{
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x000E8083 File Offset: 0x000E6283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRecyleTimeCsReq(GetRecyleTimeCsReq other) : this()
		{
			this.hNLEFMOBFKG_ = other.hNLEFMOBFKG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005686 RID: 22150 RVA: 0x000E80AD File Offset: 0x000E62AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRecyleTimeCsReq Clone()
		{
			return new GetRecyleTimeCsReq(this);
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06005687 RID: 22151 RVA: 0x000E80B5 File Offset: 0x000E62B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HNLEFMOBFKG
		{
			get
			{
				return this.hNLEFMOBFKG_;
			}
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x000E80BD File Offset: 0x000E62BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRecyleTimeCsReq);
		}

		// Token: 0x06005689 RID: 22153 RVA: 0x000E80CB File Offset: 0x000E62CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRecyleTimeCsReq other)
		{
			return other != null && (other == this || (this.hNLEFMOBFKG_.Equals(other.hNLEFMOBFKG_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600568A RID: 22154 RVA: 0x000E8100 File Offset: 0x000E6300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hNLEFMOBFKG_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600568B RID: 22155 RVA: 0x000E8134 File Offset: 0x000E6334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600568C RID: 22156 RVA: 0x000E813C File Offset: 0x000E633C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600568D RID: 22157 RVA: 0x000E8145 File Offset: 0x000E6345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hNLEFMOBFKG_.WriteTo(ref output, GetRecyleTimeCsReq._repeated_hNLEFMOBFKG_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600568E RID: 22158 RVA: 0x000E816C File Offset: 0x000E636C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hNLEFMOBFKG_.CalculateSize(GetRecyleTimeCsReq._repeated_hNLEFMOBFKG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x000E81A5 File Offset: 0x000E63A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRecyleTimeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.hNLEFMOBFKG_.Add(other.hNLEFMOBFKG_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x000E81D3 File Offset: 0x000E63D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x000E81DC File Offset: 0x000E63DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hNLEFMOBFKG_.AddEntriesFrom(ref input, GetRecyleTimeCsReq._repeated_hNLEFMOBFKG_codec);
				}
			}
		}

		// Token: 0x040021DD RID: 8669
		private static readonly MessageParser<GetRecyleTimeCsReq> _parser = new MessageParser<GetRecyleTimeCsReq>(() => new GetRecyleTimeCsReq());

		// Token: 0x040021DE RID: 8670
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021DF RID: 8671
		public const int HNLEFMOBFKGFieldNumber = 9;

		// Token: 0x040021E0 RID: 8672
		private static readonly FieldCodec<uint> _repeated_hNLEFMOBFKG_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x040021E1 RID: 8673
		private readonly RepeatedField<uint> hNLEFMOBFKG_ = new RepeatedField<uint>();
	}
}
