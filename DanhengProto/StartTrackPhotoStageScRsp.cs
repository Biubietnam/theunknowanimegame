using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011D7 RID: 4567
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartTrackPhotoStageScRsp : IMessage<StartTrackPhotoStageScRsp>, IMessage, IEquatable<StartTrackPhotoStageScRsp>, IDeepCloneable<StartTrackPhotoStageScRsp>, IBufferMessage
	{
		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x0600CC26 RID: 52262 RVA: 0x00224059 File Offset: 0x00222259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartTrackPhotoStageScRsp> Parser
		{
			get
			{
				return StartTrackPhotoStageScRsp._parser;
			}
		}

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x0600CC27 RID: 52263 RVA: 0x00224060 File Offset: 0x00222260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartTrackPhotoStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x0600CC28 RID: 52264 RVA: 0x00224072 File Offset: 0x00222272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartTrackPhotoStageScRsp.Descriptor;
			}
		}

		// Token: 0x0600CC29 RID: 52265 RVA: 0x00224079 File Offset: 0x00222279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrackPhotoStageScRsp()
		{
		}

		// Token: 0x0600CC2A RID: 52266 RVA: 0x00224081 File Offset: 0x00222281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrackPhotoStageScRsp(StartTrackPhotoStageScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.nJOONPFKHGE_ = other.nJOONPFKHGE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC2B RID: 52267 RVA: 0x002240B2 File Offset: 0x002222B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrackPhotoStageScRsp Clone()
		{
			return new StartTrackPhotoStageScRsp(this);
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x0600CC2C RID: 52268 RVA: 0x002240BA File Offset: 0x002222BA
		// (set) Token: 0x0600CC2D RID: 52269 RVA: 0x002240C2 File Offset: 0x002222C2
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

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x0600CC2E RID: 52270 RVA: 0x002240CB File Offset: 0x002222CB
		// (set) Token: 0x0600CC2F RID: 52271 RVA: 0x002240D3 File Offset: 0x002222D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NJOONPFKHGE
		{
			get
			{
				return this.nJOONPFKHGE_;
			}
			set
			{
				this.nJOONPFKHGE_ = value;
			}
		}

		// Token: 0x0600CC30 RID: 52272 RVA: 0x002240DC File Offset: 0x002222DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartTrackPhotoStageScRsp);
		}

		// Token: 0x0600CC31 RID: 52273 RVA: 0x002240EA File Offset: 0x002222EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartTrackPhotoStageScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.NJOONPFKHGE == other.NJOONPFKHGE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC32 RID: 52274 RVA: 0x00224128 File Offset: 0x00222328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.NJOONPFKHGE != 0U)
			{
				num ^= this.NJOONPFKHGE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC33 RID: 52275 RVA: 0x00224180 File Offset: 0x00222380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CC34 RID: 52276 RVA: 0x00224188 File Offset: 0x00222388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC35 RID: 52277 RVA: 0x00224194 File Offset: 0x00222394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NJOONPFKHGE != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.NJOONPFKHGE);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC36 RID: 52278 RVA: 0x002241F0 File Offset: 0x002223F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.NJOONPFKHGE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NJOONPFKHGE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC37 RID: 52279 RVA: 0x00224248 File Offset: 0x00222448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartTrackPhotoStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.NJOONPFKHGE != 0U)
			{
				this.NJOONPFKHGE = other.NJOONPFKHGE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC38 RID: 52280 RVA: 0x00224298 File Offset: 0x00222498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC39 RID: 52281 RVA: 0x002242A4 File Offset: 0x002224A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 64U)
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
					this.NJOONPFKHGE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005258 RID: 21080
		private static readonly MessageParser<StartTrackPhotoStageScRsp> _parser = new MessageParser<StartTrackPhotoStageScRsp>(() => new StartTrackPhotoStageScRsp());

		// Token: 0x04005259 RID: 21081
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400525A RID: 21082
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400525B RID: 21083
		private uint retcode_;

		// Token: 0x0400525C RID: 21084
		public const int NJOONPFKHGEFieldNumber = 6;

		// Token: 0x0400525D RID: 21085
		private uint nJOONPFKHGE_;
	}
}
