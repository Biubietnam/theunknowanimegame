using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200084F RID: 2127
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetWaypointScRsp : IMessage<GetWaypointScRsp>, IMessage, IEquatable<GetWaypointScRsp>, IDeepCloneable<GetWaypointScRsp>, IBufferMessage
	{
		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06005E8E RID: 24206 RVA: 0x000FA3FD File Offset: 0x000F85FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetWaypointScRsp> Parser
		{
			get
			{
				return GetWaypointScRsp._parser;
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x06005E8F RID: 24207 RVA: 0x000FA404 File Offset: 0x000F8604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetWaypointScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x06005E90 RID: 24208 RVA: 0x000FA416 File Offset: 0x000F8616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetWaypointScRsp.Descriptor;
			}
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x000FA41D File Offset: 0x000F861D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWaypointScRsp()
		{
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x000FA428 File Offset: 0x000F8628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWaypointScRsp(GetWaypointScRsp other) : this()
		{
			this.pKNMDPJBMAP_ = ((other.pKNMDPJBMAP_ != null) ? other.pKNMDPJBMAP_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.fALDHGHICGI_ = other.fALDHGHICGI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x000FA480 File Offset: 0x000F8680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWaypointScRsp Clone()
		{
			return new GetWaypointScRsp(this);
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x06005E94 RID: 24212 RVA: 0x000FA488 File Offset: 0x000F8688
		// (set) Token: 0x06005E95 RID: 24213 RVA: 0x000FA490 File Offset: 0x000F8690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Chapter PKNMDPJBMAP
		{
			get
			{
				return this.pKNMDPJBMAP_;
			}
			set
			{
				this.pKNMDPJBMAP_ = value;
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x06005E96 RID: 24214 RVA: 0x000FA499 File Offset: 0x000F8699
		// (set) Token: 0x06005E97 RID: 24215 RVA: 0x000FA4A1 File Offset: 0x000F86A1
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

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x06005E98 RID: 24216 RVA: 0x000FA4AA File Offset: 0x000F86AA
		// (set) Token: 0x06005E99 RID: 24217 RVA: 0x000FA4B2 File Offset: 0x000F86B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FALDHGHICGI
		{
			get
			{
				return this.fALDHGHICGI_;
			}
			set
			{
				this.fALDHGHICGI_ = value;
			}
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x000FA4BB File Offset: 0x000F86BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetWaypointScRsp);
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x000FA4CC File Offset: 0x000F86CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetWaypointScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.PKNMDPJBMAP, other.PKNMDPJBMAP) && this.Retcode == other.Retcode && this.FALDHGHICGI == other.FALDHGHICGI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x000FA52C File Offset: 0x000F872C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pKNMDPJBMAP_ != null)
			{
				num ^= this.PKNMDPJBMAP.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.FALDHGHICGI != 0U)
			{
				num ^= this.FALDHGHICGI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x000FA59A File Offset: 0x000F879A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x000FA5A2 File Offset: 0x000F87A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E9F RID: 24223 RVA: 0x000FA5AC File Offset: 0x000F87AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.pKNMDPJBMAP_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PKNMDPJBMAP);
			}
			if (this.FALDHGHICGI != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.FALDHGHICGI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x000FA624 File Offset: 0x000F8824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pKNMDPJBMAP_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PKNMDPJBMAP);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.FALDHGHICGI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FALDHGHICGI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x000FA694 File Offset: 0x000F8894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetWaypointScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pKNMDPJBMAP_ != null)
			{
				if (this.pKNMDPJBMAP_ == null)
				{
					this.PKNMDPJBMAP = new Chapter();
				}
				this.PKNMDPJBMAP.MergeFrom(other.PKNMDPJBMAP);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.FALDHGHICGI != 0U)
			{
				this.FALDHGHICGI = other.FALDHGHICGI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x000FA710 File Offset: 0x000F8910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x000FA71C File Offset: 0x000F891C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 90U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FALDHGHICGI = input.ReadUInt32();
						}
					}
					else
					{
						if (this.pKNMDPJBMAP_ == null)
						{
							this.PKNMDPJBMAP = new Chapter();
						}
						input.ReadMessage(this.PKNMDPJBMAP);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002467 RID: 9319
		private static readonly MessageParser<GetWaypointScRsp> _parser = new MessageParser<GetWaypointScRsp>(() => new GetWaypointScRsp());

		// Token: 0x04002468 RID: 9320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002469 RID: 9321
		public const int PKNMDPJBMAPFieldNumber = 11;

		// Token: 0x0400246A RID: 9322
		private Chapter pKNMDPJBMAP_;

		// Token: 0x0400246B RID: 9323
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400246C RID: 9324
		private uint retcode_;

		// Token: 0x0400246D RID: 9325
		public const int FALDHGHICGIFieldNumber = 13;

		// Token: 0x0400246E RID: 9326
		private uint fALDHGHICGI_;
	}
}
