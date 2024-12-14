using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013DD RID: 5085
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateGunPlayDataScRsp : IMessage<UpdateGunPlayDataScRsp>, IMessage, IEquatable<UpdateGunPlayDataScRsp>, IDeepCloneable<UpdateGunPlayDataScRsp>, IBufferMessage
	{
		// Token: 0x17003FA7 RID: 16295
		// (get) Token: 0x0600E2AD RID: 58029 RVA: 0x0025ADE1 File Offset: 0x00258FE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateGunPlayDataScRsp> Parser
		{
			get
			{
				return UpdateGunPlayDataScRsp._parser;
			}
		}

		// Token: 0x17003FA8 RID: 16296
		// (get) Token: 0x0600E2AE RID: 58030 RVA: 0x0025ADE8 File Offset: 0x00258FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateGunPlayDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FA9 RID: 16297
		// (get) Token: 0x0600E2AF RID: 58031 RVA: 0x0025ADFA File Offset: 0x00258FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateGunPlayDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600E2B0 RID: 58032 RVA: 0x0025AE01 File Offset: 0x00259001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateGunPlayDataScRsp()
		{
		}

		// Token: 0x0600E2B1 RID: 58033 RVA: 0x0025AE0C File Offset: 0x0025900C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateGunPlayDataScRsp(UpdateGunPlayDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.gHCJKLFLCEM_ = ((other.gHCJKLFLCEM_ != null) ? other.gHCJKLFLCEM_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2B2 RID: 58034 RVA: 0x0025AE58 File Offset: 0x00259058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateGunPlayDataScRsp Clone()
		{
			return new UpdateGunPlayDataScRsp(this);
		}

		// Token: 0x17003FAA RID: 16298
		// (get) Token: 0x0600E2B3 RID: 58035 RVA: 0x0025AE60 File Offset: 0x00259060
		// (set) Token: 0x0600E2B4 RID: 58036 RVA: 0x0025AE68 File Offset: 0x00259068
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

		// Token: 0x17003FAB RID: 16299
		// (get) Token: 0x0600E2B5 RID: 58037 RVA: 0x0025AE71 File Offset: 0x00259071
		// (set) Token: 0x0600E2B6 RID: 58038 RVA: 0x0025AE79 File Offset: 0x00259079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NNEOOKDGDIK GHCJKLFLCEM
		{
			get
			{
				return this.gHCJKLFLCEM_;
			}
			set
			{
				this.gHCJKLFLCEM_ = value;
			}
		}

		// Token: 0x0600E2B7 RID: 58039 RVA: 0x0025AE82 File Offset: 0x00259082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateGunPlayDataScRsp);
		}

		// Token: 0x0600E2B8 RID: 58040 RVA: 0x0025AE90 File Offset: 0x00259090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateGunPlayDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.GHCJKLFLCEM, other.GHCJKLFLCEM) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2B9 RID: 58041 RVA: 0x0025AEE0 File Offset: 0x002590E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.gHCJKLFLCEM_ != null)
			{
				num ^= this.GHCJKLFLCEM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E2BA RID: 58042 RVA: 0x0025AF35 File Offset: 0x00259135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E2BB RID: 58043 RVA: 0x0025AF3D File Offset: 0x0025913D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2BC RID: 58044 RVA: 0x0025AF48 File Offset: 0x00259148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.gHCJKLFLCEM_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.GHCJKLFLCEM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2BD RID: 58045 RVA: 0x0025AFA4 File Offset: 0x002591A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.gHCJKLFLCEM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GHCJKLFLCEM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E2BE RID: 58046 RVA: 0x0025AFFC File Offset: 0x002591FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateGunPlayDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.gHCJKLFLCEM_ != null)
			{
				if (this.gHCJKLFLCEM_ == null)
				{
					this.GHCJKLFLCEM = new NNEOOKDGDIK();
				}
				this.GHCJKLFLCEM.MergeFrom(other.GHCJKLFLCEM);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2BF RID: 58047 RVA: 0x0025B064 File Offset: 0x00259264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2C0 RID: 58048 RVA: 0x0025B070 File Offset: 0x00259270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.gHCJKLFLCEM_ == null)
						{
							this.GHCJKLFLCEM = new NNEOOKDGDIK();
						}
						input.ReadMessage(this.GHCJKLFLCEM);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005A23 RID: 23075
		private static readonly MessageParser<UpdateGunPlayDataScRsp> _parser = new MessageParser<UpdateGunPlayDataScRsp>(() => new UpdateGunPlayDataScRsp());

		// Token: 0x04005A24 RID: 23076
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A25 RID: 23077
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04005A26 RID: 23078
		private uint retcode_;

		// Token: 0x04005A27 RID: 23079
		public const int GHCJKLFLCEMFieldNumber = 13;

		// Token: 0x04005A28 RID: 23080
		private NNEOOKDGDIK gHCJKLFLCEM_;
	}
}
