using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000941 RID: 2369
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InterruptMissionEventScRsp : IMessage<InterruptMissionEventScRsp>, IMessage, IEquatable<InterruptMissionEventScRsp>, IDeepCloneable<InterruptMissionEventScRsp>, IBufferMessage
	{
		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x060069B5 RID: 27061 RVA: 0x0011A169 File Offset: 0x00118369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InterruptMissionEventScRsp> Parser
		{
			get
			{
				return InterruptMissionEventScRsp._parser;
			}
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x060069B6 RID: 27062 RVA: 0x0011A170 File Offset: 0x00118370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InterruptMissionEventScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x060069B7 RID: 27063 RVA: 0x0011A182 File Offset: 0x00118382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InterruptMissionEventScRsp.Descriptor;
			}
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x0011A189 File Offset: 0x00118389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptMissionEventScRsp()
		{
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x0011A191 File Offset: 0x00118391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptMissionEventScRsp(InterruptMissionEventScRsp other) : this()
		{
			this.missionEventId_ = other.missionEventId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x0011A1C2 File Offset: 0x001183C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptMissionEventScRsp Clone()
		{
			return new InterruptMissionEventScRsp(this);
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x060069BB RID: 27067 RVA: 0x0011A1CA File Offset: 0x001183CA
		// (set) Token: 0x060069BC RID: 27068 RVA: 0x0011A1D2 File Offset: 0x001183D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MissionEventId
		{
			get
			{
				return this.missionEventId_;
			}
			set
			{
				this.missionEventId_ = value;
			}
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x060069BD RID: 27069 RVA: 0x0011A1DB File Offset: 0x001183DB
		// (set) Token: 0x060069BE RID: 27070 RVA: 0x0011A1E3 File Offset: 0x001183E3
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

		// Token: 0x060069BF RID: 27071 RVA: 0x0011A1EC File Offset: 0x001183EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InterruptMissionEventScRsp);
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x0011A1FA File Offset: 0x001183FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InterruptMissionEventScRsp other)
		{
			return other != null && (other == this || (this.MissionEventId == other.MissionEventId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x0011A238 File Offset: 0x00118438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MissionEventId != 0U)
			{
				num ^= this.MissionEventId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x0011A290 File Offset: 0x00118490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x0011A298 File Offset: 0x00118498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069C4 RID: 27076 RVA: 0x0011A2A4 File Offset: 0x001184A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.MissionEventId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.MissionEventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x0011A300 File Offset: 0x00118500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MissionEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MissionEventId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x0011A358 File Offset: 0x00118558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InterruptMissionEventScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MissionEventId != 0U)
			{
				this.MissionEventId = other.MissionEventId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x0011A3A8 File Offset: 0x001185A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x0011A3B4 File Offset: 0x001185B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MissionEventId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400287D RID: 10365
		private static readonly MessageParser<InterruptMissionEventScRsp> _parser = new MessageParser<InterruptMissionEventScRsp>(() => new InterruptMissionEventScRsp());

		// Token: 0x0400287E RID: 10366
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400287F RID: 10367
		public const int MissionEventIdFieldNumber = 11;

		// Token: 0x04002880 RID: 10368
		private uint missionEventId_;

		// Token: 0x04002881 RID: 10369
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04002882 RID: 10370
		private uint retcode_;
	}
}
